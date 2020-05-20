import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import {DialogData} from '../../../../../models/dialog-data.model';
import {DatePipe} from '@angular/common';
import {FormControl} from '@angular/forms';


@Component({
  selector: 'app-news-popover',
  templateUrl: './labs-mark-popover.component.html',
  styleUrls: ['./labs-mark-popover.component.less']
})
export class LabsMarkPopoverComponent implements OnInit{

  date = new FormControl(new Date());

  constructor(
    public dialogRef: MatDialogRef<LabsMarkPopoverComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
    private datePipe: DatePipe) {
  }

  ngOnInit(): void {
    this.setDate(this.date.value);
  }

  onClick(): void {
    this.dialogRef.close();
  }

  setDate(date) {
    this.data.body.date = this.datePipe.transform(date, 'dd.MM.yyyy');
  }

}