using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}


//BURADAKİ ValidationTool ARACI, Business/ValidationRules İÇERİSİNDEKİ 
//ÇEŞİTLİ Entity LERE AİT VALİDASYON KURALLARINI KONTROL EDER.

//PROGRAMDA İNTERCEPTOR KULLANILDIĞI İÇİN, BU İŞLEMLER ATTRİBUTE ŞEKLİNDE 
//CarManager İN İÇERİSİNDE KULLANILIR.