import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { MasterPageComponent, PagesRendererService} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "testing-demos-web-forms-site-mobile-master",
   styleUrls : ["./site-mobile-master.component.css"],
   templateUrl : "./site-mobile-master.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmTestingDemos_WebFormsSite_Mobile"])
export class SiteMobileMasterComponent extends MasterPageComponent {
   MainContent_content : TemplateRef <any>;
   FeaturedContent_content : TemplateRef <any>;
   HeadContent_content : TemplateRef <any>;
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,pagesRendererService : PagesRendererService) {
      super(wmservice,changeDetector,render2,elem,pagesRendererService);
   }
   initializeContainers (page) {
      super.initializeContainers(page);
      this.MainContent_content = page.MainContent;
      this.FeaturedContent_content = page.FeaturedContent;
      this.HeadContent_content = page.HeadContent;
   }
}