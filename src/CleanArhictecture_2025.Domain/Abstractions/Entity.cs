namespace CleanArhictecture_2025.Domain.Abstractions;
public abstract class Entity
{
    public Entity()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; }

    //#region Audit Log
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeleteAt { get; set; }


    //public bool IsActive { get; set; } = true;
    //public Guid CreateUserId { get; set; } = default!;
    //public string CreateUserName => GetCreateUserName();
    //public Guid? UpdateUserId { get; set; }
    //public string? UpdateUserName => GetUpdateUserName();
    //public Guid? DeleteUserId { get; set; }
    //private string GetCreateUserName()
    //{
    //    HttpContextAccessor httpContextAccessor = new();
    //    var userManager = httpContextAccessor
    //        .HttpContext
    //        .RequestServices
    //        .GetRequiredService<UserManager<AppUser>>();

    //    AppUser appUser = userManager.Users.First(p => p.Id == CreateUserId);

    //    return appUser.FirstName + " " + appUser.LastName + " (" + appUser.Email + ")";
    //}

    //private string? GetUpdateUserName()
    //{
    //    if (UpdateUserId is null) return null;

    //    HttpContextAccessor httpContextAccessor = new();
    //    var userManager = httpContextAccessor
    //        .HttpContext
    //        .RequestServices
    //        .GetRequiredService<UserManager<AppUser>>();

    //    AppUser appUser = userManager.Users.First(p => p.Id == UpdateUserId);

    //    return appUser.FirstName + " " + appUser.LastName + " (" + appUser.Email + ")";
    //}
    //#endregion

}
