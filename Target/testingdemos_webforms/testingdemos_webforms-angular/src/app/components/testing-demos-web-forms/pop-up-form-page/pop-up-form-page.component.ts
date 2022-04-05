import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { PageComponent} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "testing-demos-web-forms-features-pop-up-form-page",
   styleUrls : ["./pop-up-form-page.component.css"],
   templateUrl : "./pop-up-form-page.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTestingDemos_WebFormsFeaturesPopUpForm"])
export class PopUpFormPageComponent extends PageComponent {
   @ViewChild('MainContent')
   MainContent : TemplateRef <any>;
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}