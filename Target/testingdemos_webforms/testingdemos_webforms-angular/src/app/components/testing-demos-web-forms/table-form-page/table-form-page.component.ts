import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { PageComponent} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "testing-demos-web-forms-table-form-page",
   styleUrls : ["./table-form-page.component.css"],
   templateUrl : "./table-form-page.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTestingDemos_WebFormsTableForm"])
export class TableFormPageComponent extends PageComponent {
   @ViewChild('MainContent')
   MainContent : TemplateRef <any>;
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}
/*
        function DoSomething(sender, args) {
            if (args.Value != "18") {
                args.IsValid = false;
                return false;
            }
            args.IsValid = true;
            return true;
        }
    */