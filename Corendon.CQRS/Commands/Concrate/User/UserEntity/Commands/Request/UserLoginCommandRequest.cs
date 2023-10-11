using Corendon.CQRS.Commands.Abstract.User.UserEntity.Commands.Request;
using System.ComponentModel.DataAnnotations;

namespace Corendon.CQRS.Commands.Concrate.User.UserEntity.Commands.Request
{
    public class UserLoginCommandRequest : IUserLoginCommandRequest
    {
        [DataType(DataType.Text), MaxLength(25), Required]
        public string? Username { get; set; }

        [DataType(DataType.Password), MaxLength(50), Required]
        public string? Password { get; set; }
    }
}
