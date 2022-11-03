import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { UserControlComponent, WebComponentsService} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "testing-demos-web-forms-view-switcher-control",
   styleUrls : ["./view-switcher-control.component.css"],
   templateUrl : "./view-switcher-control.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TestingDemos_WebFormsViewSwitcher"])
export class ViewSwitcherControlComponent extends UserControlComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,webComponents : WebComponentsService) {
      super(wmservice,changeDetector,render2,elem,webComponents);
   }
}