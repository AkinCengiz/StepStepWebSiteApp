using Microsoft.EntityFrameworkCore;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.Business.Concrete;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.DataAccess.Concrete.Contexts;
using StepStepWebSiteApp.DataAccess.Concrete.EntityFramework;

namespace StepStepWebSiteApp.MVCPresenter;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddControllersWithViews();
        //builder.Services.AddSingleton<IFeatureService, FeatureManager>();
        //builder.Services.AddSingleton<IFeatureDal, EfFeatureDal>();
        builder.Services.AddScoped<IAboutService, AboutManager>();
		builder.Services.AddScoped<IAboutDal, EfAboutDal>();
        builder.Services.AddScoped<IContactService, ContactManager>();
		builder.Services.AddScoped<IContactDal, EfContactDal>();
        builder.Services.AddScoped<IEducationService, EducationManager>();
		builder.Services.AddScoped<IEducationDal, EfEducationDal>();
		builder.Services.AddScoped<IExperienceService, ExperienceManager>();
		builder.Services.AddScoped<IExperienceDal, EfExperienceDal>();
        builder.Services.AddScoped<IFeatureService, FeatureManager>();
		builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();
		builder.Services.AddScoped<IMessageService, MessageManager>();
		builder.Services.AddScoped<IMessageDal, EfMessageDal>();
        builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
		builder.Services.AddScoped<IPortfolioDal, EfPortfolioDal>();
		builder.Services.AddScoped<IServiceService, ServiceManager>();
		builder.Services.AddScoped<IServiceDal, EfServiceDal>();
		builder.Services.AddScoped<ISkillService, SkillManager>();
		builder.Services.AddScoped<ISkillDal, EfSkillDal>();
        builder.Services.AddScoped<ISocialAccountService, SocialAccountManager>();
		builder.Services.AddScoped<ISocialAccountDal, EfSocialAccountDal>();
		builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
		builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        //builder.Services.AddTransient<IFeatureService, FeatureManager>();
		//builder.Services.AddTransient<IFeatureDal, EfFeatureDal>();

		//builder.Services.AddDbContext<StepStepWebSiteContext>(options =>
		//{
		//	options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnHome"));
		//});

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

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();
	}
}
