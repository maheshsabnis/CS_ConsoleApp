using MVC_Complete_App.BizRepositories;
// import Models and Repository Namespaces
using MVC_Complete_App.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_Complete_App.Controllers
{

    /// <summary>
    /// Controller class contains Action method.
    /// By default action methods will be executed with Http Get Request
    /// To Execute Action Method for Http Post request
    /// it must be applied with HttpPost attribute
    /// </summary>
    public class CategoryController : Controller
    {
        // define an instance of CategoryRespository using the constructor

        IBizRepository<Category, int> catRepository;

        public CategoryController()
        {
            catRepository = new CategoryBizRepository();
        }


        // GET: Category
        /// <summary>
        /// Return List of Categories
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var result = catRepository.GetData();
            // return View that will display list of Categoeies
            return View(result);
        }

        /// <summary>
        /// The method that will used to respond the view 
        /// for Accepting data for Category
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var result = new Category();
            // return a view that will show empty 
            // category information
            return View(result);
        }

        /// <summary>
        /// The Create Action method that will be executed
        /// for the Http Post request
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(Category data)
        {
            // Validate the posted model with ModelState property of the Controller base class 
            // This validations will be executed based on Validation rules applied on
            // Model classes using Data Annotations
            if (ModelState.IsValid)
            {
                // then only save the data
                data = catRepository.Create(data);
                // Redirect to the Index Action Method
                return RedirectToAction("Index");
            }
            // if the model is invalid stay on the same veiw and display
            // Validation errors
            return View(data);
        }

        /// <summary>
        /// This will accept Http Get Request with the 'id'
        /// Parameter in Request URL
        /// and will search record based on id
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            // search record
            var result = catRepository.GetData(id);
            // return view showing the searched record
            return View(result);
        }

        /// <summary>
        /// Accept the Updated values on view
        /// Validate those values and then send to database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(int id, Category data)
        {
            if (ModelState.IsValid)
            {
                catRepository.Update(id, data);
                return RedirectToAction("Index");
            }
            return View(data);
        }


        /// <summary>
        /// Delete record based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            var result = catRepository.Delete(id);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// This method will be used for Asynchronous valdiations
        /// to check if the CategoryId already presents n database
        /// Categories table
        /// </summary>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        public JsonResult CheckIfCategoryIdExist(string CategoryId)
        {


            //if(BasePrice < 0) return Json(false, JsonRequestBehavior.AllowGet);
            //return Json(true, JsonRequestBehavior.AllowGet);

            // check if the collection contsins any result
            var cat = (from c in catRepository.GetData()
                       where c.CategoryId == CategoryId
                       select c).FirstOrDefault();
            if (cat != null)
            {
                // CategoryId is already present
                // generate the response with invalid result
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            // CategoryId is not present
            // generate the response with valid result
            return Json(true, JsonRequestBehavior.AllowGet);

        }
    }
}