namespace SocialQuantum.Domain.Validation.Errors
{
	public static class CreateUserProfileErrors
	{
		public const string Required = "The field is required.";
		public const string MustBeLessThan255 = "The field cannot be greater than 255 characters.";
	}
}
