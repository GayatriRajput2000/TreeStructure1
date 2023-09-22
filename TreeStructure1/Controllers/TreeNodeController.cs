using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TreeStructure1.Controllers
{
    public class TreeNodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
public IActionResult Create(TreeNode treeNode)
{
    if (ModelState.IsValid)
    {
        DbContext.TreeNodes.Add(treeNode);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(treeNode);
}
    }
}
