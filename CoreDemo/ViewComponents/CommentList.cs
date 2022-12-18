using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment{
					ID=1,
					UserName="Ümit"
				}
				,
                new UserComment{
                    ID=2,
                    UserName="Murat"
                }
				,
                new UserComment{
                    ID=3,
                    UserName="Mesut"
                }
            };
			return View(commentvalues);
		}
	}
}
