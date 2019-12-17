using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Amazon.DynamoDBv2.DocumentModel;

namespace sample_openshift_dotnet_poc.Static
{
    public static class Common
    {
        public static AmazonDynamoDBClient GetDynamodbClient()
        {
            AmazonDynamoDBClient client = null;
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var chain = new CredentialProfileStoreChain();
            AWSCredentials awsCredentials;
            if (chain.TryGetAWSCredentials("saml", out awsCredentials))
            {
                var credentials = awsCredentials.GetCredentials();

                client = new AmazonDynamoDBClient(credentials.AccessKey, credentials.SecretKey, credentials.Token, Amazon.RegionEndpoint.APSoutheast2);

                //string strTableName = "StudentDetails";

                //var request = new GetItemRequest
                //{
                //    TableName = strTableName,
                //    Key = new Dictionary<string, AttributeValue>() { { "StudentSRN", new AttributeValue { S = "1001" } } },
                //};

                //var response = client.GetItemAsync(request);

                //// Check the response.
                //var result = response.Result;
            }

            return client;
        }

        public static System.Threading.Tasks.Task<PutItemResponse> putItemAsync(AmazonDynamoDBClient amazonDynamoDBClient, string srnNumber, string entity, string json_value)
        {
            string strTableName = "StudentDetails";
            
            var request = new PutItemRequest
            {
                TableName = strTableName,
                Item = new Dictionary<string, AttributeValue>()
                    {
                        { "StudentSRN", new AttributeValue {S = srnNumber} },
                        { entity, new AttributeValue {S = json_value } }
                    },

            };            

            return amazonDynamoDBClient.PutItemAsync(request);
        }
    }
}
