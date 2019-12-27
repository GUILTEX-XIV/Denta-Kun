# Denta-Kun   
電卓を作りたい。    


## 2019/12/25  
全く知識のない状態から電卓を作る計画を開始した。    
適当に検索してそれっぽいコードをコピペしたら動いた。    
数値１　数値２　計算方式　の入力順が不自然なので調整したいと思った。    
・変数の宣言と型の存在を知った。    
・条件分岐の方法としてswicthを知った。ifより直感的で使いやすいかもしれない。    

## 2019/12/26  
結果的に望んでいた入力順になった。  
数値　計算方式　数値！！    
num3を変数として宣言して、そこに+-*/を記憶させる予定を立てた。  
しかし、int型はstring型に変換できませんとエラーがでる。 
とりあえず1234で代用した。  
今後の課題  
・連続で計算ができるように。    
・小数点の計算に対応    
・16進数の計算に対応    
・num3に+-*/を使えるようにする。  
  
## 2019/12/27  
int型の変数には数字と符号がつかえると思っていたが、
演算記号は含まれていないようなのでstring型に変更した。
string型の宣言は null と書かなければ動かないっぽい。理由はわからないけどそうだからそうなんだと思う。  
・オペレーションの選択で +-*/ がつかえるようになった。  
・int が格納しているのは整数だけなので float に変更したら小数点の計算ができるようになった。double にすればもっと多い桁まで表示されるんだとおもう。  
・0x をつければ16進数として認識するとどこかに書いてあった。int num1 = 0x0 や、数値の入力時に0xを付けたりしてみたけどだめだった。  
連続で計算ができるようにすればとりあえず完成ということにしよう。