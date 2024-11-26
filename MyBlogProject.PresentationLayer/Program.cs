using MyBlogProject.BusinessLayer.Abstract;
using MyBlogProject.BusinessLayer.Concrete;
using MyBlogProject.DataAccessLayer.Abstract;
using MyBlogProject.DataAccessLayer.Context;
using MyBlogProject.DataAccessLayer.EntityFramework;
using MyBlogProject.EntityLayer.Concrete;
using MyBlogProject.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BlogContext>();
//identity
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<BlogContext>().AddErrorDescriber<CustomIdentityErrorValidator>();

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IArticleDal, EfArticleDal>();
builder.Services.AddScoped<IArticleService, ArticleManager>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<ISocialMediaDal,EfSocialMediaDal>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//uygulama giriþ
app.UseAuthorization();
//yetkilendirme
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
