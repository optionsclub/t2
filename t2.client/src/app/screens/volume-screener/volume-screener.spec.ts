import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export interface VolumeStock {
  symbol: string;
  volume: number;
  avgVolume: number;
  rvol: number;
}

@Component({
  selector: 'app-volume-screener',
  templateUrl: './volume-screener.html',
  styleUrls: ['./volume-screener.css']
})
export class VolumeScreenerComponent implements OnInit {

  stocks: VolumeStock[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.loadData();
  }

  loadData() {
    this.http.get<VolumeStock[]>('/api/screener/volume')
      .subscribe(data => {
        this.stocks = data;
      });
  }
}
