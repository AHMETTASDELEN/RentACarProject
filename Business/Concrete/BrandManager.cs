using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            IResult result = BusinessRules.Run(CheckIfBrandNameExist(brand.BrandName));
            if (result != null)
            {
                return new ErrorResult(Messages.BrandNotAdded);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }


        public IResult Delete(Brand brand)
        {
            IResult result = BusinessRules.Run(CheckBrandExist(brand.BrandId));
            if (result != null)
            {
                return new ErrorResult(Messages.BrandNotDeleted);
            }
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand brand)
        {
            IResult result = BusinessRules.Run(CheckIfBrandNameExist(brand.BrandName), CheckBrandExist(brand.BrandId));
            if (result != null)
            {
                return new ErrorResult(Messages.BrandNotUpdated);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }


        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }


        public IDataResult<List<Brand>> GetById(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandId == brandId), Messages.BrandsListed);
        }


        private IResult CheckBrandExist(int brandId)
        {
            var result = _brandDal.GetAll(b => b.BrandId == brandId).Any();
            if (!result)
            {
                return new ErrorResult(Messages.BrandNotFound);
            }
            return new SuccessResult();
        }


        private IResult CheckIfBrandNameExist(string brandName)
        {
            var result = _brandDal.GetAll(b => b.BrandName == brandName).Any();
            if (result == true)
            {
                return new ErrorResult(Messages.SameBrandNameExist);
            }
            return new SuccessResult();
        }
    }
}
