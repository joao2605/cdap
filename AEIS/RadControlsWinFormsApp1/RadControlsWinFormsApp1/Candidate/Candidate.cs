using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AEIS
{
    class Candidate
    {
        private int id;
        private string fullName;
        private string nameInitials;
        private int title;
        private string nationality;
        private DateTime dob;
        private string nic;
        private string addr_l1;
        private string addr_l2;
        private string addr_l3;
        private string telNo;
        private string email;
        private string img;
        private char gender;


        public Candidate()
        {

        }

        public Candidate(int id, string fullName)
        {
            this.id = id;
            this.fullName = fullName;
        }

        public Candidate(string c_fullName, string c_nameInitials, int c_title, string c_nationality, string c_nic, DateTime c_dob, char c_gender, string c_addr_l1, string c_addr_l2, string c_addr_l3, string c_telNo, string c_email, string c_img)
        {
            this.fullName = c_fullName;
            this.nameInitials = c_nameInitials;
            this.title = c_title;
            this.nationality = c_nationality;
            this.nic = c_nic;
            this.dob = c_dob;
            this.gender = c_gender;
            this.addr_l1 = c_addr_l1;
            this.addr_l2 = c_addr_l2;
            this.addr_l3 = c_addr_l3;
            this.telNo = c_telNo;
            this.email = c_email;
            this.img = c_img;

        }

        public Candidate(int c_id, string c_fullName, string c_nameInitials, int c_title, string c_nationality, string c_nic, DateTime c_dob, char c_gender, string c_addr_l1, string c_addr_l2, string c_addr_l3, string c_telNo, string c_email, string c_img)
        {
            this.id = c_id;
            this.fullName = c_fullName;
            this.nameInitials = c_nameInitials;
            this.title = c_title;
            this.nationality = c_nationality;
            this.nic = c_nic;
            this.dob = c_dob;
            this.gender = c_gender;
            this.addr_l1 = c_addr_l1;
            this.addr_l2 = c_addr_l2;
            this.addr_l3 = c_addr_l3;
            this.telNo = c_telNo;
            this.email = c_email;
            this.img = c_img;

        }

        public string getfullName()
        {
            return this.fullName;
        }

        public string getnameInitials()
        {
            return this.nameInitials;
        }

        public int gettitle()
        {
            return this.title;
        }

        public string getnationality()
        {
            return this.nationality;
        }

        public string getnic()
        {
            return this.nic;
        }

        public DateTime getdob()
        {
            return this.dob;
        }

        public char getgender()
        {
            return this.gender;
        }

        public string getaddr_l1()
        {
            return this.addr_l1;
        }

        public string getaddr_l2()
        {
            return this.addr_l2;
        }

        public string getaddr_l3()
        {
            return this.addr_l3;
        }


        public string gettelNo()
        {
            return this.telNo;
        }


        public string getemail()
        {
            return this.email;
        }

        public string getimg()
        {
            return this.img;
        }

        public void insertCandidate(Candidate c)
        {
            DB_Connect.InsertQuery("INSERT INTO candidate_tab(candidate_full_name,candidate_name_initials,candidate_title,candidate_nationality_id,candidate_nic,candidate_dob,candidate_gender,candidate_addr_l1,candidate_addr_l2, candidate_addr_l3, candidate_telno,candidate_email) VALUES('" + c.fullName + "', '" + c.nameInitials + "', '" + c.title + "', '" + c.nationality + "', '" + c.nic + "', '" + c.dob + "','" + c.gender + "','" + c.addr_l1 + " ','" + c.addr_l2 + " ','" + c.addr_l3 + " ', '" + c.telNo + "', '" + c.email + "');");

        }

        public Candidate getCandidate(int id)
        {
            //int c_id = 2;
            DataSet ds = DB_Connect.ExecuteQuery("SELECT * FROM candidate_tab WHERE candidate_id = " + id + ";");


            int cid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            string cfullName = ds.Tables[0].Rows[0][1].ToString();
            string cnameInitials = ds.Tables[0].Rows[0][2].ToString();

            int ctitleId = int.Parse(ds.Tables[0].Rows[0][3].ToString());

            string cnationality = ds.Tables[0].Rows[0][4].ToString();
            string cnic = ds.Tables[0].Rows[0][5].ToString();
            DateTime cdob = (DateTime)ds.Tables[0].Rows[0][6];
            char cgender = Convert.ToChar(ds.Tables[0].Rows[0][7].ToString());
            string caddr_l1 = ds.Tables[0].Rows[0][8].ToString();
            string caddr_l2 = ds.Tables[0].Rows[0][9].ToString();
            string caddr_l3 = ds.Tables[0].Rows[0][10].ToString();
            string ctelNo = ds.Tables[0].Rows[0][11].ToString();
            string cemail = ds.Tables[0].Rows[0][12].ToString();
            string cimg = ds.Tables[0].Rows[0][13].ToString();


            Candidate c = new Candidate(cfullName, cnameInitials, ctitleId, cnationality, cnic, cdob, cgender, caddr_l1, caddr_l2, caddr_l3, ctelNo, cemail, cimg);

            return c;


        }

        public DataSet getCandidateFullName(int id)
        {
            DataSet ds = DB_Connect.ExecuteQuery("SELECT candidate_id, candidate_full_name FROM candidate_tab WHERE candidate_id = " + id + ";");
            return ds;

        }

        public void updateCandidate(Candidate c)
        {
            DB_Connect.ExecuteQuery("UPDATE candidate_tab SET candidate_full_name = '" + c.fullName + "',candidate_name_initials = '" + c.nameInitials + "',candidate_title = '" + c.title + "',candidate_nationality_id = '" + c.nationality + "',candidate_nic = '" + c.nic + "',candidate_dob = '" + c.dob + "',candidate_gender = '" + c.gender + "',candidate_address = '" + c.addr_l1 + "',candidate_address = '" + c.addr_l2 + "',candidate_address = '" + c.addr_l3 + "',candidate_telno = '" + c.telNo + "',candidate_email = '" + c.email + "',candidate_img = '" + c.img + "' WHERE candidate_id = " + c.id + ";");

        }

        public void deleteCandidate(int id)
        {
            DB_Connect.ExecuteQuery("DELETE FROM candidate_tab WHERE candidate_id = " + id + ";");

        }


    }
}
