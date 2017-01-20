/*
 *	Formation jQuery
 *	TP 1 : Sélection et style*/

// Encapsulation :
(function ($) {

	// Au chargement de la page :
	$(document).ready(function(){
	
		/*
			EXEMPLE :
			Aligner à gauche la première ligne du <thead>
		*/
		
		// Sélection des 1eres cases avec le sélecteur CSS "thead th:first-child"
		var $premieresCasesThead = $("thead th:first-child") ;
		
		// On applique le style
		$premieresCasesThead.css("text-align","left") ;
		
		/*
			EXERCICE 1 :
			Dans chaque tableau, mettre la dernière ligne en italique
		*/

		/*
			EXERCICE 2 :
			Dans le corps des tableaux, attribuer à la première cellule de chaque ligne le style suivant :

				{
					color: #555555;
					font-weight: bold;
					text-align: left;
				}			
			
			Utiliser pour cela le format JSON.
			NB : dans l'ennoncé les styles sont écrits avec une syntaxe CSS, qui n'est pas celle que vous devez utiliser
			
		*/
		
		/*
			EXERCICE 3 :
			Attribuer à la ligne ayant l'identifiant reg24ref la couleur de fond #FBEC88
		*/
		
		/*
			EXERCICE 4 :
			Attribuer aux lignes paires des tableaux (dans le tbody) la couleur de fond  #e8e8e8
			Sauf si elles ont l'identifiant "#reg24ref"
		*/
				
	}); // Fin des instructions envoyées au chargement de la page
	
})(jQuery); // Fin de l'encapsulation
