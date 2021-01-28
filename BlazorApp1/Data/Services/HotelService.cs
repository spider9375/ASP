using System;
using System.Collections.Generic;
using System.Linq;
using BlazorApp1.Data.DB;
using BlazorApp1.Data.Interfaces;
using BlazorApp1.Data.Models;
using BlazorApp1.Data.ViewModels;

namespace BlazorApp1.Data.Services
{
    public class HotelService : IHotelService
    {
        private readonly HotelsContext dbContext;

        public HotelService(HotelsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public HotelModel Get(int id)
        {
            var entity = this.dbContext.Hotels.Find(id);

            if (entity == null)
            {
                throw new Exception("Not Found");
            }

            var result = new HotelModel()
            {
                Id = entity.Id,
                CityId = entity.CityId,
                Name = entity.Name,
                Rooms = entity.Rooms.Select(room => new RoomModel()
                {
                    Id =  room.Id,
                    BedCount = room.BedCount,
                    Price = room.Price,
                })
                .ToList()
            };

            return result;
        }


        public int Create(HotelModel model)
        {
            var entity = this.dbContext.Hotels.Create();

            entity.Id = model.Id;
            entity.CityId = model.CityId;
            entity.Name = model.Name;
            entity.Rooms = model.Rooms.Select(room => new Room()
                {
                    Price = room.Price,
                    BedCount = room.BedCount,
                })
                .ToList();

            this.dbContext.Hotels.Add(entity);
            this.dbContext.SaveChanges();

            return entity.Id;
        }

        public void Update(HotelModel model)
        {
            var entity = this.dbContext.Hotels.Find(model.Id);

            if (entity == null)
            {
                return;
            }

            entity.CityId = model.CityId;
            entity.Name = model.Name;

            foreach (var room in model.Rooms.Where(r => r.Id != 0))
            {
                var roomEntity = entity.Rooms.FirstOrDefault(x => x.Id == room.Id);
                roomEntity.BedCount = room.BedCount;
                roomEntity.Price = room.Price;
            }

            var newRooms = new List<Room>();

            foreach (var room in model.Rooms.Where(r => r.Id == 0))
            {
                var roomEntity = dbContext.Rooms.Create();

                roomEntity.HotelId = entity.Id;
                roomEntity.BedCount = room.BedCount;
                roomEntity.Price = Math.Round(room.Price, 2, MidpointRounding.AwayFromZero);

                newRooms.Add(roomEntity);
            }

            this.dbContext.Rooms.AddRange(newRooms);
            this.dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.dbContext.Hotels.Find(id);

            if (entity == null)
            {
                return;
            }

            this.dbContext.Hotels.Remove(entity);
            this.dbContext.SaveChanges();
        }

        public List<HotelViewModel> GetDataTableItems(int? regionId)
        {
            var result = this.dbContext.Hotels
                .Where(x => !regionId.HasValue || regionId == 0 || x.City.RegionId == regionId)
                .Select(x => new HotelViewModel
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City.Name,
            })
            .ToList();

            return result;
        }
    }
}
