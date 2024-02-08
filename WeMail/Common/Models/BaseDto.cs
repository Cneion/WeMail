using System;

namespace WeMail.Common.Models
{
    public class BaseDto
    {
        private int id;
        private DateTime createTime;
        private DateTime updateTime;

        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
