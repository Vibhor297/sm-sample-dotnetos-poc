using Amazon.DynamoDBv2;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Sample.Repository.Models;
using Sample.Services;
using sample_openshift_dotnet_poc.Static;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace sample_openshift_dotnet_poc
{
    public class Program
    {
        private static void Main(string[] args)
        {
            AsyncSchedule();

            //var config = new ConfigurationBuilder().AddEnvironmentVariables("")
            //    .Build();
            //// 2nd line added

            //var url = config["ASPNETCORE_URLS"] ?? "http://localhost:8080";
            //// 3rd line added

            //var host = new WebHostBuilder()
            //.UseKestrel()
            //.UseContentRoot(Directory.GetCurrentDirectory())
            //.UseIISIntegration()
            //.UseStartup<Startup>()
            //.UseUrls(url) // 4th line added
            //.Build();

            //host.Run();
            
        }

        private static async void AsyncSchedule()
        {
            await Execute();
        }

        private static async Task Execute()
        {
            using (StudentService studentService = new StudentService())
            {
                List<SepsdChangedStudent> changedStudents = await studentService.GetChangedStudents();

                //List<SepsdStudent> students = await studentService.LoadStudent(new SepsdChangedStudent());

                //var studentJson = JsonConvert.SerializeObject(students);

                //PutItemResponse response = await Common.putItemAsync(client, "447571773", "", studentJson);

                //Console.WriteLine(response.HttpStatusCode);

                //if (changedStudents.Count > 0)
                //{
                //    using (AmazonDynamoDBClient client = Common.GetDynamodbClient())
                //    {
                //        if (client != null)
                //        {
                //            TaskFactory taskFactory = new TaskFactory();
                //            //get students from ern
                //            foreach (var studentChanged in changedStudents)
                //            {
                //                var response = await taskFactory.StartNew(async () =>
                //                {
                //                    List<SepsdStudent> students = await studentService.LoadStudent(studentChanged);

                //                    var studentJson = JsonConvert.SerializeObject(students);

                //                    await Common.putItemAsync(client, studentChanged.StudentRecordNo.ToString(), "Student_Entity", studentJson);

                //                });
                //                Task.WaitAll(response);                                
                //            }
                //        }
                //        else
                //            Console.WriteLine("Error in creating AWS dynamo db session");
                //    }
                //}

                try
                {
                    using (AmazonDynamoDBClient client = Common.GetDynamodbClient())
                    {
                        TaskFactory taskFactory = new TaskFactory();
                        //get students from ern

                        var response = await taskFactory.StartNew(async () =>
                        {
                            List<SepsdStudent> students = await studentService.LoadStudent(new SepsdChangedStudent());

                            var studentJson = JsonConvert.SerializeObject(students);

                            await Common.putItemAsync(client, "447571773", "Student_Entity", studentJson);

                        });
                        Task.WaitAll(response);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        //private static async Task Scheduler()
        //{
        //    try
        //    {
        //        //NameValueCollection nameValueCollection = new NameValueCollection {
        //        //    {"quartz.threadPool.type", "Quartz.Simpl.SimpleThreadPool, Quartz" },
        //        //    { "quartz.threadPool.threadCount","10" },
        //        //    { "quartz.threadPool.threadPriority", "2" }
        //        //};

        //        StdSchedulerFactory factory = new StdSchedulerFactory();


        //        // Grab the Scheduler instance from the Factory 
        //        IScheduler scheduler = await factory.GetScheduler();

        //        // and start it off
        //        await scheduler.Start();

        //        // define the job and tie it to our HelloJob class
        //        IJobDetail job = JobBuilder.Create<HelloJob>()
        //            .WithIdentity("job1", "group1")
        //            .Build();

        //        // Trigger the job to run now, and then repeat every 10 seconds
        //        ITrigger trigger = TriggerBuilder.Create()
        //            .WithIdentity("trigger1", "group1")
        //            .StartNow()
        //            .WithSimpleSchedule(x => x
        //                .WithIntervalInSeconds(2)
        //                )
        //            .Build();

        //        // Tell quartz to schedule the job using our trigger
        //        await scheduler.ScheduleJob(job, trigger);

        //        // some sleep to show what's happening
        //        Thread.Sleep(TimeSpan.FromSeconds(60));

        //        // and last shut down the scheduler when you are ready to close your program
        //        await scheduler.Shutdown();
        //    }
        //    catch (SchedulerException se)
        //    {
        //        Console.WriteLine(se);
        //    }
        //}


    }


    //public class HelloJob : IJob
    //{
    //    async Task IJob.Execute(IJobExecutionContext context)
    //    {
    //        using (StudentService studentService = new StudentService())
    //        {
    //            List<SepsdChangedStudent> changedStudents = await studentService.GetChangedStudents();

    //            //List<SepsdStudent> students = await studentService.LoadStudent(new SepsdChangedStudent());

    //            //var studentJson = JsonConvert.SerializeObject(students);

    //            //PutItemResponse response = await Common.putItemAsync(client, "447571773", "", studentJson);

    //            //Console.WriteLine(response.HttpStatusCode);

    //            //if (changedStudents.Count > 0)
    //            //{
    //            //    using (AmazonDynamoDBClient client = Common.GetDynamodbClient())
    //            //    {
    //            //        if (client != null)
    //            //        {
    //            //            TaskFactory taskFactory = new TaskFactory();
    //            //            //get students from ern
    //            //            foreach (var studentChanged in changedStudents)
    //            //            {
    //            //                var response = await taskFactory.StartNew(async () =>
    //            //                {
    //            //                    List<SepsdStudent> students = await studentService.LoadStudent(studentChanged);

    //            //                    var studentJson = JsonConvert.SerializeObject(students);

    //            //                    await Common.putItemAsync(client, studentChanged.StudentRecordNo.ToString(), "Student_Entity", studentJson);

    //            //                });
    //            //                Task.WaitAll(response);                                
    //            //            }
    //            //        }
    //            //        else
    //            //            Console.WriteLine("Error in creating AWS dynamo db session");
    //            //    }
    //            //}

    //            try
    //            {
    //                using (AmazonDynamoDBClient client = Common.GetDynamodbClient())
    //                {
    //                    TaskFactory taskFactory = new TaskFactory();
    //                    //get students from ern

    //                    var response = await taskFactory.StartNew(async () =>
    //                    {
    //                        List<SepsdStudent> students = await studentService.LoadStudent(new SepsdChangedStudent());

    //                        var studentJson = JsonConvert.SerializeObject(students);

    //                        await Common.putItemAsync(client, "447571773", "Student_Entity", studentJson);

    //                    });
    //                    Task.WaitAll(response);
    //                }
    //            }
    //            catch(Exception ex)
    //            {
    //                Console.WriteLine(ex);
    //            }
    //        }
    //    }
    //}
}
