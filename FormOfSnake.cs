﻿// Copyright (c) Timofei Zhakov

             while(true){Console
             .Clear();var q=new
          List<int>{9,4};var r=
          new Random();int ax=r
         .Next(31),ay=r.Next(15
          ),dx=0,dy=0,i,s=0;
     void at(int x,int y,string c){
 Console.SetCursorPosition(x,y);Console
.Write(c);}void d(string c){for(i=0;i<q
.Count; i++){at(q[i],q[++i],c);}}Console.
CursorVisible=false;while(true){if(Console
.KeyAvailable){switch((int)Console.ReadKey(
true).Key){case 37:dx=-1;dy=0;break;case 39
:dx=1;dy=0;break;case 38:dx=0;dy=-1;break;
 case 40: dx=0;dy=1;break;}}d(" ");if(q[0
 ]==ax&&q[1]==ay){q.Add(0);q.Add(s++);ax=
 r.Next(31);ay=r.Next(15);}for(i=q.Count
 -1;i>1;i--)q[i]=q[i-2];q[0]=(q[0]+dx)&
 31;q[1]=(q[1]+dy)&15;for(i=2;i<q.Count
        ;i+=2)if(q[i]==q[0]&&q[i+
        1]==q[1])goto go;d("0"
         );at(ax,ay,"@");at(32,
         0,"SCORE: "+s);Thread
        .Sleep(75);}go:d("x");
         at(0,0,"GAME OVER!"+
        "\n(c) TIMA");Console
        .ReadKey(true);}