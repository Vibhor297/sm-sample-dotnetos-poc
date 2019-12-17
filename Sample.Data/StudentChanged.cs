using System;

namespace Sample.Data
{
    public class StudentChanged
    {
        public int STUDENT_RECORD_NO { get; set; }
        public DateTime RECORD_CHANGED_DATETIME { get; set; }
        public int TRANSACTION_NO { get; set; }
        public String FAMILY_NM { get; set; }
        public int DELETED { get; set; }
        public int RESYNC { get; set; }
        public int ERROR_COUNT { get; set; }
        public String STATUS { get; set; }
        public String ERROR_MESSAGE { get; set; }
        public DateTime LAST_MODIFIED { get; set; }
    }
}
