import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { PageComponent} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "testing-demos-web-forms-drop-down-list-form-page",
   styleUrls : ["./drop-down-list-form-page.component.css"],
   templateUrl : "./drop-down-list-form-page.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTestingDemos_WebFormsDropDownListForm"])
export class DropDownListFormPageComponent extends PageComponent {
   @ViewChild('MainContent')
   MainContent : TemplateRef <any>;
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}