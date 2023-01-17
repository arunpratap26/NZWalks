using FluentValidation;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Validators
{
    public class AddUpdateWalkDifficultyRequestValidator:AbstractValidator<AddUpdateWalkDifficultyRequest>
    {
        public AddUpdateWalkDifficultyRequestValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
