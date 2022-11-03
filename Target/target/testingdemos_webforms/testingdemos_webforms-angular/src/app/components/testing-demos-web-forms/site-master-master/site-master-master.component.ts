import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { MasterPageComponent, PagesRendererService} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "testing-demos-web-forms-site-master-master",
   styleUrls : ["./site-master-master.component.css","./../../../../assets/css/bootstrap.css","./../../../../assets/css/styles.css","./../../../../assets/css/carousel.css","./../../../../assets/css/menuStyles.css"],
   templateUrl : "./site-master-master.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTestingDemos_WebFormsSiteMaster"])
export class SiteMasterMasterComponent extends MasterPageComponent {
   MainContent_content : TemplateRef <any>;
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,pagesRendererService : PagesRendererService) {
      super(wmservice,changeDetector,render2,elem,pagesRendererService);
   }
   initializeContainers (page) {
      super.initializeContainers(page);
      this.MainContent_content = page.MainContent;
   }
}