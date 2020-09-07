import { Policy } from './../assets/Policy';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PoliciesService {

  readonly rootUrl = 'http://localhost:50537/api';

  constructor(private http: HttpClient) { }

  getPolicies() {
    return this.http.get<Policy[]>(this.rootUrl + '/Policies');
  }

  getPoliciesByCustomerId(customerId: string) {
    return this.http.get<Policy[]>(this.rootUrl + '/Policies/Customer/' + customerId);
  }

}
