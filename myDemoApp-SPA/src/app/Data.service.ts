import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getUsers() {
    return this.http.get('http://localhost:5000/api/employee');
  }
  getUser(userId) {
    return this.http.get('http://localhost:5000/api/employee/'+userId)
  }

  getPosts() {
    return this.http.get('http://localhost:5000/api/posts');
  }

}
