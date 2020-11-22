﻿using Ghasedak.Models;
using Ghasedak.ViewModel;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ghasedak.Service.Interface
{
    public interface IFlowerCrown
    {
        FlowerCrownAdminViewModel GetDataForAdmin(int flowerCrownId);

        object GetFlowerCrown(int charityId);
        PagedList<FlowerCrown> GetFlowerCrown(int charityId,int pageId = 1, long filterprice = 0);
        int AddFlowerCrownFromAdmin(FlowerCrown FlowerCrown);
        object AddFlowerCrown(FlowerCrownViewModelApi item, Oprator oprator);      
        
    }
}
