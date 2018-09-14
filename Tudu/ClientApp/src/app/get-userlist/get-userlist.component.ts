import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-userlist',
  templateUrl: './get-userlist.component.html'
})
export class GetUserListComponent {
  public users: User[];
  private selectedUser: User;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<User[]>(baseUrl + 'api/Users/List').subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }

  public onSelect(user: User): void {
    this.selectedUser = user;
    console.log(`Clicked user: '${this.selectedUser.name} (${this.selectedUser.id})'!`);
  }

}

interface User {
  id: number;
  name: string;
  email: string;
  website: string;
  company: string;
  city: string;
}
