import { Policy } from './../../assets/Policy';
import { Component, OnInit } from '@angular/core';
import { PoliciesService } from '../policies.service';


@Component({
  selector: 'app-policies-list',
  templateUrl: './policies-list.html',
})
export class PoliciesListComponent implements OnInit {

  public policies: Policy[];

  constructor(private data: PoliciesService) { }

  ngOnInit(): void {
    // this.GetPolicies();
    this.GetPoliciesByCustomer('1');
  }


  GetPolicies() {
    this.data.getPolicies().subscribe(data => {
      this.policies = data;
      console.log(this.policies);
    }
    );
  }

  GetPoliciesByCustomer(customerId: string) {
    this.data.getPoliciesByCustomerId(customerId).subscribe(data => {
      this.policies = data;
      console.log(this.policies);
    }
    );
  }

}
