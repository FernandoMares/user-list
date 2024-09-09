// src/app/components/user-list-component/user-list-component.component.ts

import { Component, OnInit, OnDestroy } from '@angular/core';
import { UserService } from '../../services/user-service.service';
import { Subscription, interval } from 'rxjs';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list-component.component.html',
  styleUrls: ['./user-list-component.component.scss']
})
export class UserListComponent implements OnInit, OnDestroy {
  users: any[] = [];
  private subscription: Subscription = new Subscription();

  constructor(private userService: UserService) {}

  ngOnInit() {
    this.loadUsers();
    // Fetch users every 5 seconds
    this.subscription.add(
      interval(5000).subscribe(() => this.loadUsers())
    );
  }

  loadUsers() {
    this.userService.getUsers().subscribe(
      (data) => {
        this.users = data;
      },
      (error) => {
        console.error('Error fetching users:', error);
      }
    );
  }

  ngOnDestroy() {
    this.subscription.unsubscribe(); // Clean up the interval subscription
  }
}
