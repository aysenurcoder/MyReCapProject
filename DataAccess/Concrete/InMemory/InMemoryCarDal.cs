//using DataAccess.Abstract;
//using Entities.Concrete;
//using Entities.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car> {
//                 new Car{CarId=1, BrandId=1, ColorId=3, DailyPrice=180, Description="Manuel", ModelYear="2017"},
//                 new Car{CarId=2, BrandId=4, ColorId=2, DailyPrice=250, Description="Otomatk", ModelYear="2018"},
//                 new Car{CarId=3, BrandId=3, ColorId=1, DailyPrice=300, Description="Manuel", ModelYear="2019"},
//                 new Car{CarId=4, BrandId=2, ColorId=1, DailyPrice=500, Description="Otomatk", ModelYear="2017"},
//                 new Car{CarId=5, BrandId=1, ColorId=2, DailyPrice=300, Description="Manuel", ModelYear="2020"}
//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);

//            _cars.Remove(carToDelete);

//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int id)
//        {
//            return  _cars.Where(c => c.CarId == id).ToList();
//        }

//        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;
//        }
//    }
//}
