using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VSB.Core.ViewModels.Dictionary;
using VSB.Services.Interfaces.Dictionary;

namespace VSB.Web.App.Controllers
{
    public class DictionaryController : Controller
    {
        public IActionTypeService ActionTypeService { get; set; }
        public IBrandService BrandService { get; set; }

        public IModelService ModelService { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActionType()
        {
            var models = ActionTypeService.GetItems();
            
            return PartialView(models);
        }

        public ActionResult ActionTypeForm(int id = 0)
        {
            ActionTypeViewModel model;

            if (id == 0)
                model = new ActionTypeViewModel();
            else
                model = this.ActionTypeService.GetItemById(id);

            return PartialView(model);
        }

        [HttpPost]
        public ActionResult SaveActionType(ActionTypeViewModel model)
        {
            this.ActionTypeService.SaveItem(model);

            return RedirectToAction(VSB.Core.Common.DictionaryController.Index);            
        }

        public ActionResult BrandList()
        {
            var models = this.BrandService.GetItems();

            return PartialView(models);
        }

        public ActionResult BrandForm(int id = 0)
        {
            BrandViewModel viewModel = new BrandViewModel();
           
            if (id != 0)
              viewModel = this.BrandService.GetItemById(id);

            return PartialView(viewModel);
        }

        [HttpPost]
        public ActionResult SaveBrand(BrandViewModel model)
        {
            this.BrandService.SaveItem(model);

            return RedirectToAction(VSB.Core.Common.DictionaryController.Index);
        }

        public ActionResult ModelsListForBrand(int brandId = 0)
        {
            var viewModels = (brandId == 0) ? this.ModelService.GetItems() : this.ModelService.GetModelsByBrandId(brandId);
            return PartialView(viewModels);
        }

        public ActionResult ModelForm(int id)
        {
            ModelViewModel viewModel = new ModelViewModel();

            if (id != 0)
                viewModel = this.ModelService.GetItemById(id);

            return PartialView(viewModel);
        }

        public ActionResult SaveModel(ModelViewModel model)
        {
            this.ModelService.SaveItem(model);
            return RedirectToAction(VSB.Core.Common.DictionaryController.Index);
        }
    }
}