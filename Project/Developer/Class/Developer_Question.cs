﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Developer_Question
    {
        string member_id;
        string course;
        DateTime date;
        string question_title;
        string question_details;
        string question_reply;
        string developer_id;

        public string DEVELOPER_ID
        {
            set
            {
                developer_id = value;
            }
            get
            {
                return developer_id;
            }
        }
        public string MEMBER_ID
        {
            set
            {
                member_id = value;
            }
            get
            {
                return member_id;
            }
        }

        public string COURSE
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        public DateTime DATE
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }

        public string QUESTION_TITLE
        {
            get
            {
                return question_title;
            }
            set
            {
                question_title = value;
            }
        }

        public string QUESTION_DETAILS
        {
            get
            {
                return question_details;
            }
            set
            {
                question_details = value;
            }
        }

        public string QUESTION_REPLY
        {
            get
            {
                return question_reply;
            }
            set
            {
                question_reply = value;
            }
        }
    }
}
