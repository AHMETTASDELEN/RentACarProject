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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }


        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            IResult result = BusinessRules.Run(CheckIfColorNameExist(color.ColorName));
            if (result != null)
            {
                return new ErrorResult(Messages.ColorNotAdded);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }


        public IResult Delete(Color color)
        {
            IResult result = BusinessRules.Run(CheckColorExist(color.ColorId));
            if (result != null)
            {
                return new ErrorResult(Messages.ColorNotDeleted);
            }
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }


        [ValidationAspect(typeof(ColorValidator))]
        public IResult Update(Color color)
        {
            IResult result = BusinessRules.Run(CheckIfColorNameExist(color.ColorName), CheckColorExist(color.ColorId));
            if (result != null)
            {
                return new ErrorResult(Messages.ColorNotUpdated);
            }
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }


        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
        }


        public IDataResult<List<Color>> GetById(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == colorId), Messages.ColorsListed);
        }


        private IResult CheckColorExist(int colorId)
        {
            var result = _colorDal.GetAll(c => c.ColorId == colorId).Any();
            if (!result)
            {
                return new ErrorResult(Messages.ColorNotFound);
            }
            return new SuccessResult();
        }


        private IResult CheckIfColorNameExist(string colorName)
        {
            var result = _colorDal.GetAll(c => c.ColorName == colorName).Any();
            if (result)
            {
                return new ErrorResult(Messages.SameColorNameExist);
            }
            return new SuccessResult();
        }
    }
}
