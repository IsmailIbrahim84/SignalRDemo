import {Component, OnDestroy, OnInit} from '@angular/core';
import {SignalrService} from "./signalr.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit,OnDestroy {
  title = 'SignalRClient';

  constructor(public signalService: SignalrService) {

  }

  ngOnInit(): void {
    this.signalService.startconnection();

    setTimeout(() => {
      this.signalService.AskServiceListener();
      this.signalService.AskServer();
    },2000);
  }

  ngOnDestroy(): void {
    this.signalService.hubConnection.off('skServerResponse');
  }
}
