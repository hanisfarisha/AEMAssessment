using AEMTest.Models;
using AEMTest.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AEMTest.Services
{
    
    public interface IPlatformWellService 
    {


        /// <param name="PlatformId"></param>
        Platform GetPlatformDetailsById(int PlatformId); /// get platform details by platform id

        /// <param name="PlatformId"></param>
        ResponseModel DeletePlatform(int PlatformId); /// delete platform

        List<Well> GetPlatformWellList(); /// get list of all platform and well
        /// <param name="WellId"></param>
        Well GetWellDetailsById(int WellId); /// get well details by well id
        /// <param name="wellModel"></param>
        ResponseModel SavePlatformWell(Well wellModel);///  add update platform and well
        /// <param name="WellId"></param>
        ResponseModel DeleteWell(int WellId); /// delete well

    }


    class PlatformWellService : IPlatformWellService
    {
        private readonly PlatformWellContext _context;
        public PlatformWellService(PlatformWellContext context)
        {
            _context = context;
        }

        public ResponseModel DeletePlatform(int PlatformId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Platform _temp = GetPlatformDetailsById(PlatformId);
                if (_temp != null)
                {
                    _context.Remove<Platform>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.ErrorMessage = "Platform Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.ErrorMessage = "Platform Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.ErrorMessage = "Error : " + ex.Message;
            }
            return model;
            //throw new NotImplementedException();
        }

        public Platform GetPlatformDetailsById(int PlatformId)
        {
            Platform plat;
            try
            {
                plat = _context.Find<Platform>(PlatformId);
            }
            catch (Exception)
            {
                throw;
            }
            return plat;
            //throw new NotImplementedException();
        }
        
        public List<Well> GetPlatformWellList()
        {
            List<Well> wellList;
            List<Platform> platformList;
            try
            {
                wellList = _context.Set<Well>().ToList();
                platformList = _context.Set<Platform>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return wellList;
            //throw new NotImplementedException();
        }
        public Well GetWellDetailsById(int WellId)
        {
            Well well;
            try
            {
                well = _context.Find<Well>(WellId);
            }
            catch (Exception)
            {
                throw;
            }
            return well;
            //throw new NotImplementedException();
        }

        public ResponseModel SavePlatformWell(Well wellModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Well _tempo = GetWellDetailsById(wellModel.WellId);
                if (_tempo != null)
                {
                    _tempo.PlatformId = wellModel.PlatformId;
                    _tempo.WellString = wellModel.WellString;
                    _tempo.UpdatedDatetime = wellModel.UpdatedDatetime;
                    _tempo.Deleted = wellModel.Deleted;
                    _context.Update<Well>(_tempo);
                    model.ErrorMessage = "Well Update Successfully";
                }
                else
                {
                    _context.Add<Well>(wellModel);
                    model.ErrorMessage = "Well Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.ErrorMessage = "Error : " + ex.Message;
            }
            return model;
            //throw new NotImplementedException();
        }

        public ResponseModel DeleteWell(int WellId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Well _temp = GetWellDetailsById(WellId);
                if (_temp != null)
                {
                    _context.Remove<Well>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.ErrorMessage = "Well Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.ErrorMessage = "Well Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.ErrorMessage = "Error : " + ex.Message;
            }
            return model;
            //throw new NotImplementedException();
        }
    }

}

