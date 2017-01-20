/*
 *	Formation jQuery
 *	TP 7 : Fonctions
 *  Script pour la d�claration des fonctions
 * 	Inspir� d'un plugin d'Alen Grakalic (http://cssglobe.com/post/1695/easiest-tooltip-and-image-preview-using-jquery)
*/

// Encapsulation :
(function ($) {

	// Surcharge des m�thodes de jQuery  : 
	$.fn.extend({
		
		// M�thode pour activer une item dans le menu des onglets
		activeOnglet: function(options){
			
			// Configuration par d�faut
			var confDefault = {
				classeActive : "active",
				valeurRetour : false 
			}
			
			// Surcharge de la configuration
			var conf = $.extend(
				confDefault,
				options
			) ;	
			
			// This renvoie directement le groupe de noeuds auquel la m�thode s'applique
			var $listeOnglets = this ;
			
			$listeOnglets.click(function(){
			
				// Onglet cliqu� : 
				var $onglet = $(this) ;

				// On enl�ve la classe sur tous les items
				$listeOnglets.removeClass(conf.classeActive) ;

				// On met la classe active sur l'item qui a �t� cliqu�
				$onglet.addClass(conf.classeActive) ;

				// Ex�cution du clique ?
				return conf.valeurRetour ;
					
			})
			
			// On active le premier onglet
			$listeOnglets.eq(0).click() ;
			
			// M�thode chainable (i.e. return this)
			return $listeOnglets ;
			
		} // Fin de la m�thode activeOnglet()
		
	}); // Fin de la surcharge des fonctions 
	
})(jQuery); // Fin de l'encapsulation
