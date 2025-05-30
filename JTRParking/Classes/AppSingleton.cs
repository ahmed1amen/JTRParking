﻿using JTRParking.Database;
using JTRParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTRParking.Classes
{
    public class AppSingleton
    {
        private static AppSingleton _instance;
        public User current_user { get; set; }
        public List<Setting> current_settings { get; set; }

        public void refreshSettings()
        {
            using (var context = new JTRDbContext())
            {
                List<Setting> settings = context.Settings.ToList();
                this.current_settings= settings;
            }
        }
        public static AppSingleton Instance
        {
            get
            {
                if (AppSingleton._instance == null)
                    AppSingleton._instance = new AppSingleton();
                return AppSingleton._instance;
            }
        }

    }



}
