u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . D r a w i n g ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o m p o n e n t M o d e l ;  
 u s i n g   S y s t e m . W i n d o w s . F o r m s ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D a t a . S q l C l i e n t ;  
  
 n a m e s p a c e   E B S   {  
 	 / / /   < s u m m a r y >  
 	 / / /   S u m m a r y   d e s c r i p t i o n   f o r   E B S 0 1 .  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   c l a s s   E B S 0 1   :   E B S F o r m   {  
 	 	 p r i v a t e   A x O W C 1 1 . A x S p r e a d s h e e t   s h e e t ;  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   R e q u i r e d   d e s i g n e r   v a r i a b l e .  
 	 	 / / /   < / s u m m a r y >  
 	 	 p r i v a t e   S y s t e m . C o m p o n e n t M o d e l . C o n t a i n e r   c o m p o n e n t s   =   n u l l ;  
  
 	 	 p u b l i c   E B S 0 1 ( )   {  
 	 	 	 / /  
 	 	 	 / /   R e q u i r e d   f o r   W i n d o w s   F o r m   D e s i g n e r   s u p p o r t  
 	 	 	 / /  
 	 	 	 I n i t i a l i z e C o m p o n e n t ( ) ;  
  
 	 	 	 e b s   =   " E B S 0 1 " ;  
  
 	 	 	 D a t a R o w [ ]   d e s c R o w s   =   D B . G e t D e s c ( e b s ) ;  
 	 	 	 f o r   ( i n t   i = 0 ;   i < d e s c R o w s . L e n g t h ;   i + + )   {  
 	 	 	 	 m a p . A d d ( C o n v e r t . T o I n t 3 2 ( d e s c R o w s [ i ] [ " c _ S h e e t R o w " ] ) ,   d e s c R o w s [ i ] [ " c _ I d " ] . T o S t r i n g ( ) ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   C l e a n   u p   a n y   r e s o u r c e s   b e i n g   u s e d .  
 	 	 / / /   < / s u m m a r y >  
 	 	 p r o t e c t e d   o v e r r i d e   v o i d   D i s p o s e (   b o o l   d i s p o s i n g   )   {  
 	 	 	 i f (   d i s p o s i n g   )   {  
 	 	 	 	 i f ( c o m p o n e n t s   ! =   n u l l )   {  
 	 	 	 	 	 c o m p o n e n t s . D i s p o s e ( ) ;  
 	 	 	 	 }  
 	 	 	 }  
 	 	 	 b a s e . D i s p o s e (   d i s p o s i n g   ) ;  
 	 	 }  
  
 	 	 # r e g i o n   W i n d o w s   F o r m   D e s i g n e r   g e n e r a t e d   c o d e  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   R e q u i r e d   m e t h o d   f o r   D e s i g n e r   s u p p o r t   -   d o   n o t   m o d i f y  
 	 	 / / /   t h e   c o n t e n t s   o f   t h i s   m e t h o d   w i t h   t h e   c o d e   e d i t o r .  
 	 	 / / /   < / s u m m a r y >  
 	 	 p r i v a t e   v o i d   I n i t i a l i z e C o m p o n e n t ( )   {  
 	 	 	 S y s t e m . R e s o u r c e s . R e s o u r c e M a n a g e r   r e s o u r c e s   =   n e w   S y s t e m . R e s o u r c e s . R e s o u r c e M a n a g e r ( t y p e o f ( E B S 0 1 ) ) ;  
 	 	 	 t h i s . s h e e t   =   n e w   A x O W C 1 1 . A x S p r e a d s h e e t ( ) ;  
 	 	 	 ( ( S y s t e m . C o m p o n e n t M o d e l . I S u p p o r t I n i t i a l i z e ) ( t h i s . s h e e t ) ) . B e g i n I n i t ( ) ;  
 	 	 	 t h i s . S u s p e n d L a y o u t ( ) ;  
 	 	 	 / /    
 	 	 	 / /   c o m b o S c h o o l  
 	 	 	 / /    
 	 	 	 t h i s . c o m b o S c h o o l . N a m e   =   " c o m b o S c h o o l " ;  
 	 	 	 t h i s . c o m b o S c h o o l . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 1 8 4 ,   2 1 ) ;  
 	 	 	 / /    
 	 	 	 / /   c o m b o Y e a r  
 	 	 	 / /    
 	 	 	 t h i s . c o m b o Y e a r . N a m e   =   " c o m b o Y e a r " ;  
 	 	 	 t h i s . c o m b o Y e a r . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 7 2 ,   2 1 ) ;  
 	 	 	 / /    
 	 	 	 / /   c o m b o R e g i o n  
 	 	 	 / /    
 	 	 	 t h i s . c o m b o R e g i o n . N a m e   =   " c o m b o R e g i o n " ;  
 	 	 	 t h i s . c o m b o R e g i o n . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 1 3 6 ,   2 1 ) ;  
 	 	 	 / /    
 	 	 	 / /   p a n e l H e a d  
 	 	 	 / /    
 	 	 	 t h i s . p a n e l H e a d . N a m e   =   " p a n e l H e a d " ;  
 	 	 	 t h i s . p a n e l H e a d . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 7 6 0 ,   2 4 ) ;  
 	 	 	 / /    
 	 	 	 / /   l a b e l S c h o o l  
 	 	 	 / /    
 	 	 	 t h i s . l a b e l S c h o o l . N a m e   =   " l a b e l S c h o o l " ;  
 	 	 	 / /    
 	 	 	 / /   l a b e l Y e a r  
 	 	 	 / /    
 	 	 	 t h i s . l a b e l Y e a r . N a m e   =   " l a b e l Y e a r " ;  
 	 	 	 / /    
 	 	 	 / /   l a b e l R e g i o n  
 	 	 	 / /    
 	 	 	 t h i s . l a b e l R e g i o n . N a m e   =   " l a b e l R e g i o n " ;  
 	 	 	 / /    
 	 	 	 / /   s h e e t  
 	 	 	 / /    
 	 	 	 t h i s . s h e e t . D a t a S o u r c e   =   n u l l ;  
 	 	 	 t h i s . s h e e t . D o c k   =   S y s t e m . W i n d o w s . F o r m s . D o c k S t y l e . F i l l ;  
 	 	 	 t h i s . s h e e t . E n a b l e d   =   t r u e ;  
 	 	 	 t h i s . s h e e t . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 0 ,   2 4 ) ;  
 	 	 	 t h i s . s h e e t . N a m e   =   " s h e e t " ;  
 	 	 	 t h i s . s h e e t . O c x S t a t e   =   ( ( S y s t e m . W i n d o w s . F o r m s . A x H o s t . S t a t e ) ( r e s o u r c e s . G e t O b j e c t ( " s h e e t . O c x S t a t e " ) ) ) ;  
 	 	 	 t h i s . s h e e t . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 7 6 0 ,   4 6 9 ) ;  
 	 	 	 t h i s . s h e e t . T a b I n d e x   =   0 ;  
 	 	 	 t h i s . s h e e t . E n t e r   + =   n e w   S y s t e m . E v e n t H a n d l e r ( t h i s . s h e e t _ E n t e r ) ;  
 	 	 	 / /    
 	 	 	 / /   E B S 0 1  
 	 	 	 / /    
 	 	 	 t h i s . A u t o S c a l e B a s e S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 5 ,   1 3 ) ;  
 	 	 	 t h i s . C l i e n t S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 7 6 0 ,   4 9 3 ) ;  
 	 	 	 t h i s . C o n t r o l s . A d d ( t h i s . s h e e t ) ;  
 	 	 	 t h i s . I c o n   =   ( ( S y s t e m . D r a w i n g . I c o n ) ( r e s o u r c e s . G e t O b j e c t ( " $ t h i s . I c o n " ) ) ) ;  
 	 	 	 t h i s . N a m e   =   " E B S 0 1 " ;  
 	 	 	 t h i s . T e x t   =   " E B S 0 1   <0O3B  -   !C@0;F03G4K=  B09;0=" ;  
 	 	 	 t h i s . C o n t r o l s . S e t C h i l d I n d e x ( t h i s . p a n e l H e a d ,   0 ) ;  
 	 	 	 t h i s . C o n t r o l s . S e t C h i l d I n d e x ( t h i s . s h e e t ,   0 ) ;  
 	 	 	 ( ( S y s t e m . C o m p o n e n t M o d e l . I S u p p o r t I n i t i a l i z e ) ( t h i s . s h e e t ) ) . E n d I n i t ( ) ;  
 	 	 	 t h i s . R e s u m e L a y o u t ( f a l s e ) ;  
  
 	 	 }  
 	 	 # e n d r e g i o n  
  
 	 	 p u b l i c   o v e r r i d e   v o i d   C l e a r C o n t e n t ( )   {  
 	 	 	 t r y   {  
 	 	 	 	 s h e e t . g e t _ R a n g e ( " C 3 " ,   " M 3 1 " ) . C l e a r C o n t e n t s ( ) ;  
 	 	 	 	 s h e e t . g e t _ R a n g e ( " C 3 6 " ,   " M 7 5 " ) . C l e a r C o n t e n t s ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h { }  
 	 	 }  
  
 	 	 p u b l i c   o v e r r i d e   v o i d   L o a d D a t a ( )   {  
 	 	 	 C u r s o r . C u r r e n t   =   C u r s o r s . W a i t C u r s o r ;  
  
 	 	 	 t r y   {  
 	 	 	 	 s h e e t . C e l l s [ 3 6 ,   1 ]   =   y e a r   -   6 ;   / /     . g e t _ R a n g e ( " A 3 6 " ,   " A 3 6 " ) . V a l u e 2    
 	 	 	 	 i f   ( D B . d s E b s . E b s 0 1 . S e l e c t ( " c _ a r c i d = "   +   a r c i d ) . L e n g t h   = =   0 )   {  
 	 	 	 	 	 D B . L o a d E B S ( e b s ,   a r c i d ) ;  
 	 	 	 	 }  
 	 	 	  
 	 	 	 	 f o r e a c h   ( i n t   j   i n   m a p . K e y s )   {  
 	 	 	 	 	 i n t   k   =   1 ;  
 	 	 	 	 	 f o r   ( c h a r   i = ' C ' ;   i < = ' M '   & &   k < = 1 1 ;   i + + ,   k + + )   {  
 	 	 	 	 	 	 D a t a R o w   v a l   =   D B . d s E b s . E b s 0 1 . F i n d B y c _ A r c I d c _ D e s c I d c _ C l a s s ( a r c i d ,   m a p [ j ] . T o S t r i n g ( ) ,   k ) ;  
 	 	 	 	 	 	 i f   ( v a l   ! =   n u l l )   S e t V a l u e ( s h e e t ,   i   +   " "   +   j ,   v a l [ " c _ C o u n t " ] ) ;  
 	 	 	 	 	 }  
 	 	 	 	 }  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 C u r s o r . C u r r e n t   =   C u r s o r s . D e f a u l t ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   o v e r r i d e   v o i d   S a v e D a t a ( )   {  
 	 	 	 C u r s o r . C u r r e n t   =   C u r s o r s . W a i t C u r s o r ;  
  
 	 	 	 D B . C l e a r E B S ( e b s ,   a r c i d ) ;  
  
 	 	 	 f o r e a c h   ( i n t   j   i n   m a p . K e y s )   {  
 	 	 	 	 i n t   k   =   1 ;  
 	 	 	 	 f o r   ( c h a r   i = ' C ' ;   i < = ' M '   & &   k   < =   1 1 ;   i + + ,   k + + )   {  
 	 	 	 	 	 t r y   {  
 	 	 	 	 	 	 i n t   v a l   =   G e t V a l u e ( s h e e t ,   i   +   " "   +   j ) ;  
 	 	 	 	 	 	 i f   ( v a l   >   0 )   D B . S a v e E B S ( a r c i d ,   m a p [ j ] . T o S t r i n g ( ) ,   k ,   v a l ) ;  
 	 	 	 	 	 }  
 	 	 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 	 	 M e s s a g e B o x . S h o w ( " �4= "   +   i   +   j   +   " : "   +   e x . M e s s a g e ) ;  
 	 	 	 	 	 }  
 	 	 	 	 }  
 	 	 	 }  
  
 	 	 	 C u r s o r . C u r r e n t   =   C u r s o r s . D e f a u l t ;  
 	 	 }  
  
 	 	 p r i v a t e   v o i d   s h e e t _ E n t e r ( o b j e c t   s e n d e r ,   S y s t e m . E v e n t A r g s   e )   {  
 	 	  
 	 	 }  
  
 	 	  
 	 	  
  
 	 	  
 	 }  
 }  
 
