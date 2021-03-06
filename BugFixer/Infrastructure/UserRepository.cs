﻿using BugFixer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BugFixer.Infrastructure {
    public class UserRepository {

        private ApplicationDbContext _db;

        public UserRepository(DbContext db) {
            _db = (ApplicationDbContext)db;
        }

        public IQueryable<ApplicationUser> FindUsers() {
            return from u in _db.Users
                   select u;
        }

        public IQueryable<ApplicationUser> FindByUsername(string username) {
            return from u in _db.Users
                   where u.UserName == username 
                   select u;
        }
    }
}