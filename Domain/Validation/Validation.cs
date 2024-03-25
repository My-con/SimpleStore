using System.ComponentModel.DataAnnotations;

public static class ValidationEntities<T> where T : class{
    public static List<ValidationResult> GetValidation(T ToValide){
        ValidationContext ValidationContext = new ValidationContext(ToValide);

        List<ValidationResult> Result = new();

        Validator.TryValidateObject(ToValide, ValidationContext, Result, true);       

        return Result;
    }
}