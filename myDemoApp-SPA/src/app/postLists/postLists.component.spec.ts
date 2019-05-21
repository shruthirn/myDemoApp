/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PostListsComponent } from './postLists.component';

describe('PostListsComponent', () => {
  let component: PostListsComponent;
  let fixture: ComponentFixture<PostListsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostListsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostListsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
