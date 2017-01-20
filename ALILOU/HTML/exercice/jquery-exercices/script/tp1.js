/*
 *	Formation jQuery
 *	TP 1 : S�lection et style*/

// Encapsulation :
(function ($) {

	// Au chargement de la page :
	$(document).ready(function(){
	
		/*
			EXEMPLE :
			Aligner � gauche la premi�re ligne du <thead>
		*/
		
		// S�lection des 1eres cases avec le s�lecteur CSS "thead th:first-child"
		var $premieresCasesThead = $("thead th:first-child") ;
		
		// On applique le style
		$premieresCasesThead.css("text-align","left") ;
		
		/*
			EXERCICE 1 :
			Dans chaque tableau, mettre la derni�re ligne en italique
		*/

		/*
			EXERCICE 2 :
			Dans le corps des tableaux, attribuer � la premi�re cellule de chaque ligne le style suivant :

				{
					color: #555555;
					font-weight: bold;
					text-align: left;
				}			
			
			Utiliser pour cela le format JSON.
			NB : dans l'ennonc� les styles sont �crits avec une syntaxe CSS, qui n'est pas celle que vous devez utiliser
			
		*/
		
		/*
			EXERCICE 3 :
			Attribuer � la ligne ayant l'identifiant reg24ref la couleur de fond #FBEC88
		*/
		
		/*
			EXERCICE 4 :
			Attribuer aux lignes paires des tableaux (dans le tbody) la couleur de fond  #e8e8e8
			Sauf si elles ont l'identifiant "#reg24ref"
		*/
				
	}); // Fin des instructions envoy�es au chargement de la page
	
})(jQuery); // Fin de l'encapsulation
