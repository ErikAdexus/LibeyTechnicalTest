import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { user } from '../models/user.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class usersService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllusers(): Observable<user[]> { 
    return this.http.get<user[]>(this.baseApiUrl + 'LibeyUser');
  }

  adduser(adduserRequest: user) : Observable<user>{ 
    return this.http.post<user>(this.baseApiUrl + 'LibeyUser', adduserRequest);
  }

  getuser(id: string): Observable<user> { 
    return this.http.get<user>(this.baseApiUrl + 'LibeyUser/' + id);
  }

  edituser(id: string, edituserRequest: user) : Observable<user>{ 
    return this.http.put<user>(this.baseApiUrl + 'LibeyUser/' + id, edituserRequest);
  }

  deleteuser(id: string) : Observable<user>{ 
    return this.http.delete<user>(this.baseApiUrl + 'LibeyUser/' + id);
  }
}
