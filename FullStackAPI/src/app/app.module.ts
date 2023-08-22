import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { usersListComponent } from './components/users/users-list/users-list.component';
import { AdduserComponent } from './components/users/add-user/add-user.component';
import { FormsModule } from '@angular/forms';
import { EdituserComponent } from './components/users/edit-user/edit-user.component';

@NgModule({
  declarations: [
    AppComponent,
    usersListComponent,
    AdduserComponent,
    EdituserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
