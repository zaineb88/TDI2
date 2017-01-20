/*
 *	Formation jQuery
 *	TP 2 : Attributs, classes, contenus texte et html*/

// Encapsulation :
(function ($) {

	// Au chargement de la page :
	$(document).ready(function(){
	
		/*
			EXEMPLE
			Attribuer aux dernières lignes de chaque tableau la classe region-reference.
		*/
		
		// Sélection de la dernière ligne de chaque tableau
		var $derniereLigne = $("tbody tr:last-child");
		
		// On applique la méthode .addClass() à notre sélection
		$derniereLigne.addClass("region-reference");
		
		// /* Chainage : */ $("tbody tr:last-child").addClass("region-reference");
	
		/*
			EXERCICE 1
			Mettre un attribut title valant "Provisoire" aux cellules qui ont la classe provisoire.
		*/
				
		/*
			EXERCICE 2
			Dans les cellules vides, écrire « n.d » et ajouter la classe non-defini.
		*/
				
		/*
			EXERCICE 3
			Mettre la classe non-significatif aux cellules dont l'attribut title contient "non significatif"
		*/
				
		/*
			EXERCICE 4
			Récupérer le contenu texte du lien ayant l'identifiant id-ligne-active.
			Ce contenu est l'identifiant de la ligne à laquelle vous devez mettre la classe class-ligne-active.
			A la place du code, mettre le nom de la région active dans le lien ayant l'identifiant id-ligne-active.
		*/
		
	}); // Fin des instructions envoyées au chargement de la page
	
})(jQuery); // Fin de l'encapsulation
