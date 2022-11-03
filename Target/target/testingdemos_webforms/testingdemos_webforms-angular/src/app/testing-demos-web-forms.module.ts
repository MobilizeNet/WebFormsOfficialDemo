
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';
import { WebFormsModule } from '@mobilize/webforms-components';
import { AjaxModule } from '@mobilize/webforms-components';

import * as TestingDemosWebForms from './components/testing-demos-web-forms';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
    WebFormsModule,
    AjaxModule,
  ],
  exports: [
    TestingDemosWebForms.AboutPageComponent,
    TestingDemosWebForms.CalendarFormPageComponent,
    TestingDemosWebForms.CheckBoxFormPageComponent,
    TestingDemosWebForms.ContactFormPageComponent,
    TestingDemosWebForms.ContactPageComponent,
    TestingDemosWebForms.DataListFormPageComponent,
    TestingDemosWebForms.DefaultPageComponent,
    TestingDemosWebForms.DropDownListFormPageComponent,
    TestingDemosWebForms.GridViewFormPageComponent,
    TestingDemosWebForms.MailFormPageComponent,
    TestingDemosWebForms.OtherComponentsPageComponent,
    TestingDemosWebForms.PopUpFormPageComponent,
    TestingDemosWebForms.ProductDetailsPageComponent,
    TestingDemosWebForms.SiteMasterMasterComponent,
    TestingDemosWebForms.SiteMobileMasterComponent,
    TestingDemosWebForms.TableFormPageComponent,
    TestingDemosWebForms.ViewSwitcherControlComponent,
    TestingDemosWebForms.WebForm1PageComponent,
  ],
  declarations: [
    TestingDemosWebForms.AboutPageComponent,
    TestingDemosWebForms.CalendarFormPageComponent,
    TestingDemosWebForms.CheckBoxFormPageComponent,
    TestingDemosWebForms.ContactFormPageComponent,
    TestingDemosWebForms.ContactPageComponent,
    TestingDemosWebForms.DataListFormPageComponent,
    TestingDemosWebForms.DefaultPageComponent,
    TestingDemosWebForms.DropDownListFormPageComponent,
    TestingDemosWebForms.GridViewFormPageComponent,
    TestingDemosWebForms.MailFormPageComponent,
    TestingDemosWebForms.OtherComponentsPageComponent,
    TestingDemosWebForms.PopUpFormPageComponent,
    TestingDemosWebForms.ProductDetailsPageComponent,
    TestingDemosWebForms.SiteMasterMasterComponent,
    TestingDemosWebForms.SiteMobileMasterComponent,
    TestingDemosWebForms.TableFormPageComponent,
    TestingDemosWebForms.ViewSwitcherControlComponent,
    TestingDemosWebForms.WebForm1PageComponent,
  ],
  bootstrap: [
    TestingDemosWebForms.AboutPageComponent,
    TestingDemosWebForms.CalendarFormPageComponent,
    TestingDemosWebForms.CheckBoxFormPageComponent,
    TestingDemosWebForms.ContactFormPageComponent,
    TestingDemosWebForms.ContactPageComponent,
    TestingDemosWebForms.DataListFormPageComponent,
    TestingDemosWebForms.DefaultPageComponent,
    TestingDemosWebForms.DropDownListFormPageComponent,
    TestingDemosWebForms.GridViewFormPageComponent,
    TestingDemosWebForms.MailFormPageComponent,
    TestingDemosWebForms.OtherComponentsPageComponent,
    TestingDemosWebForms.PopUpFormPageComponent,
    TestingDemosWebForms.ProductDetailsPageComponent,
    TestingDemosWebForms.SiteMasterMasterComponent,
    TestingDemosWebForms.SiteMobileMasterComponent,
    TestingDemosWebForms.TableFormPageComponent,
    TestingDemosWebForms.ViewSwitcherControlComponent,
    TestingDemosWebForms.WebForm1PageComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class TestingDemosWebFormsModule { }

