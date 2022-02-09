using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportTool.ViewModels
{
    public class CLIENT
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string TENANT { get; set; }
        public long UNIKEY { get; set; }
        public string HOSTBY { get; set; }
        public string EDITBY { get; set; }
        public string ID { get; set; }
        public string ISACTIVE { get; set; }
        public string CODE { get; set; }
        public string SALUTATION { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string ADDR1 { get; set; }
        public string ADDR2 { get; set; }
        public string CITY { get; set; }
        public string PROVID { get; set; }
        public string CTRY { get; set; }
        public string ZIP { get; set; }

        public string EMAIL { get; set; }

        public string AREAH { get; set; }

        public string FONEH { get; set; }

        public string EXTH { get; set; }

        public string LDH { get; set; }

        public string AREAW { get; set; }

        public string FONEW { get; set; }

        public string EXTW { get; set; }

        public string LDW { get; set; }

        public string AREAC { get; set; }

        public string FONEC { get; set; }

        public string LDC { get; set; }

        public Nullable<int> PRIMCONT { get; set; }

        public string STAFF1ID { get; set; }

        public string STAFF2ID { get; set; }

        public string NOTESID { get; set; }

        public string LASTSTAFF { get; set; }

        public Nullable<int> STAFFCOUNT { get; set; }

        public string REFERREDBY { get; set; }

        public Nullable<int> REFF { get; set; }

        public Nullable<int> CREF { get; set; }

        public Nullable<System.DateTime> BIRTHDAY { get; set; }

        public Nullable<System.DateTime> STARTDATE { get; set; }

        public Nullable<System.DateTime> LASTVISIT { get; set; }

        public string SEX { get; set; }

        public string TAX1 { get; set; }

        public string TAX2 { get; set; }

        public string SERVDISC { get; set; }

        public string RETDISC { get; set; }

        public string OCCUPATION { get; set; }

        public string NOCCCHECK { get; set; }

        public string OLCODE { get; set; }

        public string UNAME { get; set; }

        public string COMPANY { get; set; }

        public string CCREDIT1 { get; set; }

        public string CCREDIT2 { get; set; }

        public string CCREDIT3 { get; set; }

        public Nullable<System.DateTime> CEXPIRY { get; set; }

        public string MEMBER { get; set; }

        public Nullable<System.DateTime> MEXPIRY { get; set; }

        public string FAMILYID { get; set; }

        public Nullable<double> AVGRCPTS { get; set; }

        public Nullable<double> AVGDAYS { get; set; }

        public Nullable<int> VISITS { get; set; }

        public Nullable<int> NUMTICK { get; set; }

        public string SUSER1 { get; set; }

        public string SUSER2 { get; set; }

        public string SUSER3 { get; set; }

        public string SUSER4 { get; set; }

        public Nullable<System.DateTime> DUSER1 { get; set; }

        public Nullable<System.DateTime> DUSER2 { get; set; }

        public string CUSER1 { get; set; }

        public string CUSER2 { get; set; }

        public string ISDELETED_IBSF { get; set; }

        public Nullable<double> REWARD { get; set; }

        public Nullable<double> YTDS { get; set; }

        public Nullable<double> YTDR { get; set; }

        public Nullable<double> LYTDS { get; set; }

        public Nullable<double> LYTDR { get; set; }

        public string STORECODE { get; set; }

        public string NOEMAIL { get; set; }

        public string NOLETTER { get; set; }

        public Nullable<int> SENTBYEAR { get; set; }

        public string SENTREF { get; set; }

        public string SENTPOINTS { get; set; }

        public string SENTNEW { get; set; }

        public Nullable<System.DateTime> SENTINACT { get; set; }

        public Nullable<System.DateTime> SENTBOOK { get; set; }

        public Nullable<int> PNTSBYEAR { get; set; }

        public string CCMONTHEXP { get; set; }

        public string CCYEAREXP { get; set; }

        public Nullable<System.DateTime> FOLLOWUP { get; set; }

        public string NOREMINDER { get; set; }

        public Nullable<double> LFREWARD { get; set; }

        public string ACCOUNTID { get; set; }

        public string PNTSEXE { get; set; }

        public string NOERECEIPT { get; set; }

        public string LOYALTYNO { get; set; }

        public string TAX2RETAILONLYEXEMPT { get; set; }

        public System.DateTime LASTTOUCH { get; set; }

    }
}
