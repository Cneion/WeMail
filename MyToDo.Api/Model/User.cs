﻿namespace MyToDo.Api.Model {
    public class User : BaseEntity{
        public string Account { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
    }
}