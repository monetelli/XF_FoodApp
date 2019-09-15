﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF_FoodApp.Models;
using XF_FoodApp.Services;

namespace XF_FoodApp.ViewModels
{
    public class DiscoverViewModel : BindableObject
    {

        #region Properties
        private List<Restaurant> _listRestaurant;

        public List<Restaurant> ListRestaurant
        {
            get { return _listRestaurant; }
            set
            {
                _listRestaurant = value;
                OnPropertyChanged();
            }
        }

        private List<Category> _listCategory;

        public List<Category> ListCategory
        {
            get { return _listCategory; }
            set
            {
                _listCategory = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Constructors
        public DiscoverViewModel()
        {
            GetService();
        }
        #endregion


        #region CRUD Services
        public void GetService()
        {
            var service = new MainService();
            ListRestaurant = service.GetRestaurant();
            ListCategory = service.GetCategory();
        }
        #endregion
    }
}
