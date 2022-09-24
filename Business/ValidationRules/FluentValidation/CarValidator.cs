using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            //RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.ModelYear).GreaterThan(2010);

            RuleFor(c => c.DailyPrice).NotEmpty();
            //RuleFor(c => c.Description).NotEmpty();
            //RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.BrandId).NotEmpty();
            //RuleFor(c => c.ColorId).NotEmpty();
        }
    }
}

//BU CLASS DA ARABALARA AİT VALİDASYON KURALLARI YAZILIR

//BU KURALLAR Core/CrossCuttıngConcerns/Validation 
//İÇERİSİNDEKİ ValidatinTool ARACI KULLANILARAK VALİDASYON İŞLEMİ YAPILIR

//PROGRAMDA İNTERCEPTOR KULLANILDIĞI İÇİN, BU İŞLEMLER ATTRİBUTE ŞEKLİNDE 
//CarManager İN İÇERİSİNDE KULLANILIR