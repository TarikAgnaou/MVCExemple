Créer un controlleur du nom de la page à afficher

Créer un dossier avec le même nom que le controller dans le repetroire view
	chaque fichier *.cshtml dans ce dossier sera appelé par une méthode du même nom que le fichier dans le controller

http://localhost:1234/[Controller]/[methode]?[var1]=xxx&[var2]=yyy

Dans les fichiers *.cshtml toute les commandes faisant reference à razor debute avec @

@ViewData["xxx"] => les données sont récupéré via cette commande

Créer un lien en razor
	<a class="navbar-brand" asp-area="" asp-controller="Movies" asp-action="Index">Movie App</a>
		asp-controller="xxx"	=> fait référence au controller qui doit être appelé
		asp-action="xxx"		=> appel la méthode du controller appelé precedemment
		asp-area=""				=> 

Indiquer à razor dans quel format on recoit les données :
	@model [projet].Models.[class]
	@model IEnumerable<[projet].Models.[class]>

On passe les données du controller vers la vue par retunr View(new [class]);

On fait appel à chaque champs par @Html.DisplayFor([class] => [class].[champ]);

Dans le model on peut décorer chaque champs avec :
	- [Display(Name = "xxx")]	=>	quel nom lui donnera-t-on à l'affichage
	- [DataType(DataType.Date)]	=>	quel style de type de donnée va-t-on afficher

Dans le fichier _ViewStart.cshtml on définie quel layout on va utiliser par rapport à quel controller on utilise
	@{
	    ViewBag.QSParameter = Context.Request.Query["parameter"];

	    var controller = Context.Request.RouteValues["Controller"].ToString();

	    if (controller != "Admin")
	    {
        	Layout = "~/Views/Shared/_Layout.cshtml";
	    }
	    else
	    {
        	Layout = "~/Views/Admin/_Layout.cshtml";
	    }
	}
	
