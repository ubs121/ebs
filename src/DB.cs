u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . X m l ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D a t a . S q l C l i e n t ;  
 u s i n g   S y s t e m . W i n d o w s . F o r m s ;  
 u s i n g   S y s t e m . C o n f i g u r a t i o n ;  
  
 n a m e s p a c e   E B S   {  
 	 / / /   < s u m m a r y >  
 	 / / /   S u m m a r y   d e s c r i p t i o n   f o r   D B .  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   c l a s s   D B   {  
 	 	 p u b l i c   s t a t i c   s t r i n g   s t r C o n ;  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S   d s E b s ;  
 	 	 p r i v a t e   s t a t i c   S q l C o m m a n d   s q l S a v e E b s ;  
 	 	 p r i v a t e   s t a t i c   S q l C o m m a n d   s q l S a v e E b s V 2 ;  
 	 	 p r i v a t e   s t a t i c   S q l C o m m a n d   s q l S a v e E b s V 3 ;  
 	 	 p r i v a t e   s t a t i c   S q l C o m m a n d   s q l S a v e E b s V 4 ;  
 	 	 p r i v a t e   s t a t i c   S q l C o m m a n d   s q l S a v e E b s V 5 ;  
 	 	 p r i v a t e   s t a t i c   S q l D a t a A d a p t e r   d a S c h o o l ;  
 	 	 p r i v a t e   s t a t i c   S q l D a t a A d a p t e r   d a T e a c h e r ;  
 	 	 p r i v a t e   s t a t i c   S q l D a t a A d a p t e r   d a E q u i p m e n t ;  
 	 	 p r i v a t e   s t a t i c   S q l D a t a A d a p t e r   d a B u i l d i n g ;  
 	 	 p r i v a t e   s t a t i c   S q l D a t a A d a p t e r   d a H u s b a n d r y ;  
 	 	  
 	 	 s t a t i c   D B ( )   {  
 	 	 	 s t r C o n   =   s t r i n g . F o r m a t ( " a p p l i c a t i o n   n a m e = E B S ; p e r s i s t   s e c u r i t y   i n f o = t r u e ; p a c k e t   s i z e = 4 0 9 6 ; d a t a   s o u r c e = { 0 } ; i n i t i a l   c a t a l o g = { 1 } ; u s e r   i d = { 2 } ; p a s s w o r d = { 3 } ; " ,   A p p S e t t i n g . G e t ( " D a t a S e r v e r " ) ,   " e b s " ,   A p p S e t t i n g . G e t ( " D a t a U s e r " ) ,   A p p S e t t i n g . D e c r y p t P a s s w o r d ( A p p S e t t i n g . G e t ( " D a t a P a s s w o r d " ) ) ) ;  
 	 	 	 d s E b s   =   n e w   D a t a s e t E B S ( ) ;  
  
 	 	 	 d a S c h o o l   =   n e w   S q l D a t a A d a p t e r ( ) ;  
 	 	 	 d a S c h o o l . S e l e c t C o m m a n d   =   n e w   S q l C o m m a n d ( " s e l e c t   *   f r o m   t _ s c h o o l   w h e r e   c _ r i d = @ r i d " ) ;  
 	 	 	 d a S c h o o l . S e l e c t C o m m a n d . P a r a m e t e r s . A d d ( " @ r i d " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d   =   n e w   S q l C o m m a n d ( " s p _ S a v e S c h o o l " ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ s i d " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ r i d " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ n a m e " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ t y p e " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ s p e c " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ i s b r a n c h " ,   S q l D b T y p e . B i t ,   1 ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ n o t e " ,   S q l D b T y p e . N V a r C h a r ,   1 0 0 ) ;  
 	 	 	 d a S c h o o l . D e l e t e C o m m a n d   =   n e w   S q l C o m m a n d ( " d e l e t e   t _ s c h o o l   w h e r e   c _ s i d = @ s i d   a n d   c _ r i d = @ r i d " ) ;  
 	 	 	 d a S c h o o l . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ s i d " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a S c h o o l . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ r i d " ,   S q l D b T y p e . I n t ,   4 ) ;  
  
 	 	 	 d a T e a c h e r   =   n e w   S q l D a t a A d a p t e r ( ) ;  
 	 	 	 d a T e a c h e r . S e l e c t C o m m a n d   =   n e w   S q l C o m m a n d ( " s e l e c t   *   f r o m   t _ t e a c h e r   w h e r e   c _ a r c i d = @ a r c i d " ) ;  
 	 	 	 d a T e a c h e r . S e l e c t C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d   =   n e w   S q l C o m m a n d ( " s p _ S a v e T e a c h e r " ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ n a m e " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a g e " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ s e x " ,   S q l D b T y p e . N V a r C h a r ,   2 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ r e g n o " ,   S q l D b T y p e . N V a r C h a r ,   1 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ f a m i l y " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ p r o f " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ p o s i t i o n " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ d e g r e e " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ p r o f d e g r e e " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ e d u c a t i o n " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ w o r k e d y e a r " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d   =   n e w   S q l C o m m a n d ( " d e l e t e   t _ t e a c h e r   w h e r e   c _ a r c i d = @ a r c i d   a n d   c _ n a m e = @ n a m e " ) ;  
 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ n a m e " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
  
 	 	 	 d a E q u i p m e n t   =   n e w   S q l D a t a A d a p t e r ( ) ;  
 	 	 	 d a E q u i p m e n t . S e l e c t C o m m a n d   =   n e w   S q l C o m m a n d ( " s e l e c t   *   f r o m   t _ e q u i p m e n t   w h e r e   c _ a r c i d = @ a r c i d " ) ;  
 	 	 	 d a E q u i p m e n t . S e l e c t C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d   =   n e w   S q l C o m m a n d ( " s p _ S a v e E q u i p m e n t " ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ e q u i p m e n t " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ t y p e " ,   S q l D b T y p e . N V a r C h a r ,   3 0 ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ c o u n t " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a c o u n t " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ c o s t " ,   S q l D b T y p e . M o n e y ,   8 ) ;  
 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d   =   n e w   S q l C o m m a n d ( " d e l e t e   t _ e q u i p m e n t   w h e r e   c _ a r c i d = @ a r c i d   a n d   c _ e q u i p m e n t = @ e q u i p m e n t " ) ;  
 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ e q u i p m e n t " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
  
 	 	 	 d a B u i l d i n g   =   n e w   S q l D a t a A d a p t e r ( ) ;  
 	 	 	 d a B u i l d i n g . S e l e c t C o m m a n d   =   n e w   S q l C o m m a n d ( " s e l e c t   *   f r o m   t _ b u i l d i n g   w h e r e   c _ a r c i d = @ a r c i d " ) ;  
 	 	 	 d a B u i l d i n g . S e l e c t C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d   =   n e w   S q l C o m m a n d ( " s p _ S a v e B u i l d i n g " ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ b u i l d i n g " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ d e s c " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ b u i l d y e a r " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ c a r d i n a l i t y " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ r o o m c o u n t " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ q u a l i t y " ,   S q l D b T y p e . N V a r C h a r ,   2 0 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ c o s t " ,   S q l D b T y p e . M o n e y ,   8 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a v a i l a b l e " ,   S q l D b T y p e . B i t ,   1 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ u s i n g b y d e s c " ,   S q l D b T y p e . B i t ,   1 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ h e a t i n g t y p e " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ h e a t i n g c a p a c i t y " ,   S q l D b T y p e . R e a l ,   8 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ n e c a p a b l e " ,   S q l D b T y p e . B i t ,   1 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ u s a b l e i n w i n t e r " ,   S q l D b T y p e . B i t ,   1 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ r e p a i r n e e d " ,   S q l D b T y p e . B i t ,   1 ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ r e p a i r c o s t " ,   S q l D b T y p e . M o n e y ,   8 ) ;  
 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d   =   n e w   S q l C o m m a n d ( " d e l e t e   t _ b u i l d i n g   w h e r e   c _ a r c i d = @ a r c i d   a n d   c _ b u i l d i n g = @ b u i l d i n g " ) ;  
 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d . P a r a m e t e r s . A d d ( " @ b u i l d i n g " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
  
 	 	 	 d a H u s b a n d r y   =   n e w   S q l D a t a A d a p t e r ( ) ;  
 	 	 	 d a H u s b a n d r y . S e l e c t C o m m a n d   =   n e w   S q l C o m m a n d ( " s e l e c t   *   f r o m   t _ h u s b a n d r y   w h e r e   c _ a r c i d = @ a r c i d " ) ;  
 	 	 	 d a H u s b a n d r y . S e l e c t C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d   =   n e w   S q l C o m m a n d ( " s p _ S a v e H u s b a n d r y " ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ a n i m a l s " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ h a r v e s t " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ f i e l d " ,   S q l D b T y p e . R e a l ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ s h e e p " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ g o a t " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ c o w " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ h o r s e " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ c a m e l " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ p i g " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ b i r d " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ s e e d " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ v e g e t a b l e " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s . A d d ( " @ f r u i t " ,   S q l D b T y p e . I n t ,   4 ) ;  
  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   b o o l   L o g i n ( )   {  
 	 	 	 b o o l   s u c c e s s   =   f a l s e ;  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 s u c c e s s   =   t r u e ;  
 	 	 	 }  
 	 	 	 c a t c h   {  
 	 	 	 	 s u c c e s s   =   f a l s e ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
  
 	 	 	 r e t u r n   s u c c e s s ;  
 	 	 }  
  
 	 	 p r i v a t e   s t a t i c   v o i d   L o a d R e g i o n ( )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 S q l D a t a A d a p t e r   d a R e g i o n   =   n e w   S q l D a t a A d a p t e r ( " s e l e c t   c _ r i d ,   c _ n a m e   f r o m   t _ r e g i o n " ,   c o n ) ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . R e g i o n . C l e a r ( ) ;  
 	 	 	 	 d a R e g i o n . F i l l ( d s E b s ,   " R e g i o n " ) ;  
 	 	 	 	 D a t a s e t E B S . R e g i o n R o w   r o w   =   d s E b s . R e g i o n . N e w R e g i o n R o w ( ) ;  
 	 	 	 	 r o w . c _ R i d   =   0 ;  
 	 	 	 	 r o w . c _ N a m e   =   " ( C;AK=  EM<6MM=4) " ;  
 	 	 	 	 d s E b s . R e g i o n . A d d R e g i o n R o w ( r o w ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S . R e g i o n D a t a T a b l e   R e g i o n s   {  
 	 	 	 g e t   {  
 	 	 	 	 i f   ( d s E b s . R e g i o n . R o w s . C o u n t   = =   0 )    
 	 	 	 	 	 L o a d R e g i o n ( ) ;  
  
 	 	 	 	 r e t u r n   d s E b s . R e g i o n ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   L o a d S c h o o l ( i n t   r i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a S c h o o l . S e l e c t C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . S c h o o l . C l e a r ( ) ;  
 	 	 	 	 d a S c h o o l . S e l e c t C o m m a n d . P a r a m e t e r s [ " @ r i d " ] . V a l u e   =   r i d ;  
 	 	 	 	 d a S c h o o l . F i l l ( d s E b s ,   " S c h o o l " ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S . S c h o o l D a t a T a b l e   S c h o o l s   {  
 	 	 	 g e t   {  
 	 	 	 	 r e t u r n   d s E b s . S c h o o l ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e ( S c h o o l   s )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ s i d " ] . V a l u e   =   s . s i d ;  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ r i d " ] . V a l u e   =   s . r i d ;  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ n a m e " ] . V a l u e   =   s . n a m e ;  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ t y p e " ] . V a l u e   =   s . t y p e ;  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ s p e c " ] . V a l u e   =   s . s p e c ;  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ i s b r a n c h " ] . V a l u e   =   s . i s b r a n c h ;  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ n o t e " ] . V a l u e   =   s . n o t e ;  
  
 	 	 	 	 d a S c h o o l . U p d a t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   D e l e t e S c h o o l ( i n t   s i d ,   i n t   r i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a S c h o o l . D e l e t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d a S c h o o l . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ s i d " ] . V a l u e   =   s i d ;  
 	 	 	 	 d a S c h o o l . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ r i d " ] . V a l u e   =   r i d ;  
 	 	 	 	 d a S c h o o l . D e l e t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   L o a d B u i l d i n g ( l o n g   a r c i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a B u i l d i n g . S e l e c t C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . B u i l d i n g . C l e a r ( ) ;  
 	 	 	 	 d a B u i l d i n g . S e l e c t C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a B u i l d i n g . F i l l ( d s E b s ,   " B u i l d i n g " ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S . B u i l d i n g D a t a T a b l e   B u i l d i n g s   {  
 	 	 	 g e t   {  
 	 	 	 	 r e t u r n   d s E b s . B u i l d i n g ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e ( B u i l d i n g   b )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . B u i l d i n g . C l e a r ( ) ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   b . a r c i d ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ b u i l d i n g " ] . V a l u e   =   b . b u i l d i n g ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ d e s c " ] . V a l u e   =   b . d e s c ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ b u i l d y e a r " ] . V a l u e   =   b . b u i l d y e a r ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ c a r d i n a l i t y " ] . V a l u e   =   b . c a r d i n a l i t y ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ r o o m c o u n t " ] . V a l u e   =   b . r o o m c o u n t ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ q u a l i t y " ] . V a l u e   =   b . q u a l i t y ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ c o s t " ] . V a l u e   =   b . c o s t ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a v a i l a b l e " ] . V a l u e   =   b . a v a i l a b l e ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ u s i n g b y d e s c " ] . V a l u e   =   b . u s i n g b y d e s c ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ h e a t i n g t y p e " ] . V a l u e   =   b . h e a t i n g t y p e ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ h e a t i n g c a p a c i t y " ] . V a l u e   =   b . h e a t i n g c a p a c i t y ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ n e c a p a b l e " ] . V a l u e   =   b . n e c a p a b l e ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ u s a b l e i n w i n t e r " ] . V a l u e   =   b . u s a b l e i n w i n t e r ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ r e p a i r n e e d " ] . V a l u e   =   b . r e p a i r n e e d ;  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ r e p a i r c o s t " ] . V a l u e   =   b . r e p a i r c o s t ;  
 	 	 	 	  
 	 	 	 	 d a B u i l d i n g . U p d a t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   D e l e t e B u i l d i n g ( l o n g   a r c i d ,   s t r i n g   b u i l d i n g )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . B u i l d i n g . C l e a r ( ) ;  
 	 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ b u i l d i n g " ] . V a l u e   =   b u i l d i n g ;  
 	 	 	 	 d a B u i l d i n g . D e l e t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   L o a d E q u i p m e n t ( l o n g   a r c i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a E q u i p m e n t . S e l e c t C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . E q u i p m e n t . C l e a r ( ) ;  
 	 	 	 	 d a E q u i p m e n t . S e l e c t C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a E q u i p m e n t . F i l l ( d s E b s ,   " E q u i p m e n t " ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S . E q u i p m e n t D a t a T a b l e   E q u i p m e n t s   {  
 	 	 	 g e t   {  
 	 	 	 	 r e t u r n   d s E b s . E q u i p m e n t ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e ( E q u i p m e n t   e )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   e . a r c i d ;  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ e q u i p m e n t " ] . V a l u e   =   e . e q u i p m e n t ;  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ t y p e " ] . V a l u e   =   e . t y p e ;  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ c o u n t " ] . V a l u e   =   e . c o u n t ;  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a c o u n t " ] . V a l u e   =   e . a c o u n t ;  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ c o s t " ] . V a l u e   =   e . c o s t ;  
  
 	 	 	 	 d a E q u i p m e n t . U p d a t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   D e l e t e E q u i p m e n t ( l o n g   a r c i d ,   s t r i n g   e q )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ e q u i p m e n t " ] . V a l u e   =   e q ;  
 	 	 	 	 d a E q u i p m e n t . D e l e t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   L o a d H u s b a n d r y ( l o n g   a r c i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a H u s b a n d r y . S e l e c t C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . H u s b a n d r y . C l e a r ( ) ;  
 	 	 	 	 d a H u s b a n d r y . S e l e c t C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a H u s b a n d r y . F i l l ( d s E b s ,   " H u s b a n d r y " ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S . H u s b a n d r y D a t a T a b l e   H u s b a n d r y   {  
 	 	 	 g e t   {  
 	 	 	 	 r e t u r n   d s E b s . H u s b a n d r y ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e ( H u s b a n d r y   h )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   h . a r c i d ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a n i m a l s " ] . V a l u e   =   h . a n i m a l s ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ h a r v e s t " ] . V a l u e   =   h . h a r v e s t ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ f i e l d " ] . V a l u e   =   h . f i e l d ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ s h e e p " ] . V a l u e   =   h . s h e e p ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ g o a t " ] . V a l u e   =   h . g o a t ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ c o w " ] . V a l u e   =   h . c o w ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ h o r s e " ] . V a l u e   =   h . h o r s e ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ c a m e l " ] . V a l u e   =   h . c a m e l ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ p i g " ] . V a l u e   =   h . p i g ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ b i r d " ] . V a l u e   =   h . b i r d ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ s e e d " ] . V a l u e   =   h . s e e d ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ v e g e t a b l e " ] . V a l u e   =   h . v e g e t a b l e ;  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ f r u i t " ] . V a l u e   =   h . f r u i t ;  
  
 	 	 	 	 d a H u s b a n d r y . U p d a t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   L o a d T e a c h e r ( l o n g   a r c i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a T e a c h e r . S e l e c t C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . T e a c h e r . C l e a r ( ) ;  
 	 	 	 	 d a T e a c h e r . S e l e c t C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a T e a c h e r . F i l l ( d s E b s ,   " T e a c h e r " ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a s e t E B S . T e a c h e r D a t a T a b l e   T e a c h e r s   {  
 	 	 	 g e t   {  
 	 	 	 	 r e t u r n   d s E b s . T e a c h e r ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e ( T e a c h e r   t )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   t . a r c i d ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ n a m e " ] . V a l u e   =   t . n a m e ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ a g e " ] . V a l u e   =   t . a g e ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ s e x " ] . V a l u e   =   t . s e x ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ r e g n o " ] . V a l u e   =   t . r e g n o ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ f a m i l y " ] . V a l u e   =   t . f a m i l y ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ p r o f " ] . V a l u e   =   t . p r o f ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ p o s i t i o n " ] . V a l u e   =   t . p o s i t i o n ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ d e g r e e " ] . V a l u e   =   t . d e g r e e ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ p r o f d e g r e e " ] . V a l u e   =   t . p r o f d e g r e e ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ e d u c a t i o n " ] . V a l u e   =   t . e d u c a t i o n ;  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . P a r a m e t e r s [ " @ w o r k e d y e a r " ] . V a l u e   =   t . w o r k e d y e a r ;  
  
 	 	 	 	 d a T e a c h e r . U p d a t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   D e l e t e T e a c h e r ( l o n g   a r c i d ,   s t r i n g   n a m e )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d . P a r a m e t e r s [ " @ n a m e " ] . V a l u e   =   n a m e ;  
 	 	 	 	 d a T e a c h e r . D e l e t e C o m m a n d . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
 	 	 p r i v a t e   s t a t i c   v o i d   L o a d D e s c ( )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 S q l D a t a A d a p t e r   d a D e s c   =   n e w   S q l D a t a A d a p t e r ( " s e l e c t   *   f r o m   t _ d e s c r i p t i o n " ,   c o n ) ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . D e s c r i p t i o n . C l e a r ( ) ;  
 	 	 	 	 d a D e s c . F i l l ( d s E b s ,   " D e s c r i p t i o n " ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   D a t a R o w [ ]   G e t D e s c ( s t r i n g   d e s c )   {  
 	 	 	 i f   ( d s E b s . D e s c r i p t i o n . R o w s . C o u n t   = =   0 )    
 	 	 	 	 L o a d D e s c ( ) ;  
  
 	 	 	 r e t u r n   d s E b s . D e s c r i p t i o n . S e l e c t ( " c _ i d   l i k e   ' "   +   d e s c   +   " * ' " ) ;  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   L o a d E B S ( s t r i n g   e b s ,   l o n g   a r c i d )   {  
 	 	 	 / / i f   ( 1 0 0 0   <   a r c i d   & &   a r c i d   <   9 9 9 9 )   S u m E B S ( e b s ,   a r c i d ) ;   / /   ? ? ?  
  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 S q l D a t a A d a p t e r   d a E b s   =   n e w   S q l D a t a A d a p t e r ( " s e l e c t   *   f r o m   t _ "   +   e b s   +   "   w h e r e   c _ a r c i d = "   +   a r c i d ,   c o n ) ;  
 	 	 	 d s E b s . E n f o r c e C o n s t r a i n t s   =   f a l s e ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 d s E b s . T a b l e s [ e b s ] . C l e a r ( ) ;  
 	 	 	 	 d a E b s . F i l l ( d s E b s ,   e b s ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S u m E B S ( s t r i n g   e b s ,   l o n g   a r c i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 S q l C o m m a n d   s q l S u m E B S   =   n e w   S q l C o m m a n d ( " s p _ S u m E B S " ,   c o n ) ;  
 	 	 	 s q l S u m E B S . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 s q l S u m E B S . P a r a m e t e r s . A d d ( " @ e b s " ,   S q l D b T y p e . V a r C h a r ,   2 0 ) ;  
 	 	 	 s q l S u m E B S . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
  
 	 	 	 	 s q l S u m E B S . P a r a m e t e r s [ " @ e b s " ] . V a l u e   =   e b s ;  
 	 	 	 	 s q l S u m E B S . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 s q l S u m E B S . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   C l e a r E B S ( s t r i n g   e b s ,   l o n g   a r c i d )   {  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 S q l C o m m a n d   s q l C l e a r E b s   =   n e w   S q l C o m m a n d ( " d e l e t e   t _ "   +   e b s   +   "   w h e r e   c _ a r c i d = "   +   a r c i d ,   c o n ) ;  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
 	 	 	 	 s q l C l e a r E b s . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   ( E x c e p t i o n   e x )   {  
 	 	 	 	 M e s s a g e B o x . S h o w ( e x . M e s s a g e ,   " E B S " ,   M e s s a g e B o x B u t t o n s . O K ,   M e s s a g e B o x I c o n . E r r o r ) ;  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e E B S ( l o n g   a r c i d ,   s t r i n g   d e s c i d ,   i n t   c l ,   i n t   v a l )   {  
 	 	 	 i f   ( s q l S a v e E b s   = =   n u l l )   {  
 	 	 	 	 s q l S a v e E b s   =   n e w   S q l C o m m a n d ( " s p _ S a v e E b s " ) ;  
 	 	 	 	 s q l S a v e E b s . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s . A d d ( " @ d e s c i d " ,   S q l D b T y p e . V a r C h a r ,   2 0 ) ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s . A d d ( " @ c l a s s " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s . A d d ( " @ v a l " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 }  
 	 	 	  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 s q l S a v e E b s . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s [ " @ d e s c i d " ] . V a l u e   =   d e s c i d ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s [ " @ c l a s s " ] . V a l u e   =   c l ;  
 	 	 	 	 s q l S a v e E b s . P a r a m e t e r s [ " @ v a l " ] . V a l u e   =   v a l ;  
  
 	 	 	 	 s q l S a v e E b s . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   {  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e E B S ( l o n g   a r c i d ,   s t r i n g   d e s c i d ,   s t r i n g   p r o f ,   i n t   v a l )   {  
 	 	 	 i f   ( s q l S a v e E b s V 2   = =   n u l l )   {  
 	 	 	 	 s q l S a v e E b s V 2   =   n e w   S q l C o m m a n d ( " s p _ S a v e E b s V 2 " ) ;  
 	 	 	 	 s q l S a v e E b s V 2 . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s . A d d ( " @ d e s c i d " ,   S q l D b T y p e . V a r C h a r ,   2 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s . A d d ( " @ p r o f " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s . A d d ( " @ v a l " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 }  
 	 	 	  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 s q l S a v e E b s V 2 . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s [ " @ d e s c i d " ] . V a l u e   =   d e s c i d ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s [ " @ p r o f " ] . V a l u e   =   p r o f ;  
 	 	 	 	 s q l S a v e E b s V 2 . P a r a m e t e r s [ " @ v a l " ] . V a l u e   =   v a l ;  
  
 	 	 	 	 s q l S a v e E b s V 2 . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   {  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e E B S ( l o n g   a r c i d ,   s t r i n g   d e s c i d ,   s t r i n g   d e t ,   f l o a t   v a l )   {  
 	 	 	 i f   ( s q l S a v e E b s V 4   = =   n u l l )   {  
 	 	 	 	 s q l S a v e E b s V 4   =   n e w   S q l C o m m a n d ( " s p _ S a v e E b s V 4 " ) ;  
 	 	 	 	 s q l S a v e E b s V 4 . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s . A d d ( " @ d e s c i d " ,   S q l D b T y p e . V a r C h a r ,   2 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s . A d d ( " @ d e t " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s . A d d ( " @ v a l " ,   S q l D b T y p e . M o n e y ,   8 ) ;  
 	 	 	 }  
 	 	 	  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 s q l S a v e E b s V 4 . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s [ " @ d e s c i d " ] . V a l u e   =   d e s c i d ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s [ " @ d e t " ] . V a l u e   =   d e t ;  
 	 	 	 	 s q l S a v e E b s V 4 . P a r a m e t e r s [ " @ v a l " ] . V a l u e   =   v a l ;  
  
 	 	 	 	 s q l S a v e E b s V 4 . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   {  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e E B S ( l o n g   a r c i d ,   s t r i n g   d e s c i d ,   i n t   c l ,   s t r i n g   l e s s o n ,   i n t   v a l )   {  
 	 	 	 i f   ( s q l S a v e E b s V 3   = =   n u l l )   {  
 	 	 	 	 s q l S a v e E b s V 3   =   n e w   S q l C o m m a n d ( " s p _ S a v e E b s V 3 " ) ;  
 	 	 	 	 s q l S a v e E b s V 3 . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s . A d d ( " @ d e s c i d " ,   S q l D b T y p e . V a r C h a r ,   2 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s . A d d ( " @ c l a s s " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s . A d d ( " @ l e s s o n " ,   S q l D b T y p e . N V a r C h a r ,   5 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s . A d d ( " @ v a l " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 }  
 	 	 	  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 s q l S a v e E b s V 3 . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s [ " @ d e s c i d " ] . V a l u e   =   d e s c i d ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s [ " @ c l a s s " ] . V a l u e   =   c l ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s [ " @ l e s s o n " ] . V a l u e   =   l e s s o n ;  
 	 	 	 	 s q l S a v e E b s V 3 . P a r a m e t e r s [ " @ v a l " ] . V a l u e   =   v a l ;  
  
 	 	 	 	 s q l S a v e E b s V 3 . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   {  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
  
  
 	 	 p u b l i c   s t a t i c   v o i d   S a v e E B S ( l o n g   a r c i d ,   s t r i n g   d e s c i d ,   i n t   v a l 1 ,   i n t   v a l 2 ,   i n t   v a l 3 ,   i n t   v a l 4 )   {  
 	 	 	 i f   ( s q l S a v e E b s V 5   = =   n u l l )   {  
 	 	 	 	 s q l S a v e E b s V 5   =   n e w   S q l C o m m a n d ( " s p _ S a v e E b s V 5 " ) ;  
 	 	 	 	 s q l S a v e E b s V 5 . C o m m a n d T y p e   =   C o m m a n d T y p e . S t o r e d P r o c e d u r e ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s . A d d ( " @ a r c i d " ,   S q l D b T y p e . B i g I n t ,   8 ) ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s . A d d ( " @ d e s c i d " ,   S q l D b T y p e . V a r C h a r ,   2 0 ) ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s . A d d ( " @ v a l 1 " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s . A d d ( " @ v a l 2 " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s . A d d ( " @ v a l 3 " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s . A d d ( " @ v a l 4 " ,   S q l D b T y p e . I n t ,   4 ) ;  
 	 	 	 }  
 	 	 	  
 	 	 	 S q l C o n n e c t i o n   c o n   =   n e w   S q l C o n n e c t i o n ( s t r C o n ) ;  
 	 	 	 s q l S a v e E b s V 5 . C o n n e c t i o n   =   c o n ;  
  
 	 	 	 t r y   {  
 	 	 	 	 c o n . O p e n ( ) ;  
  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s [ " @ a r c i d " ] . V a l u e   =   a r c i d ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s [ " @ d e s c i d " ] . V a l u e   =   d e s c i d ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s [ " @ v a l 1 " ] . V a l u e   =   v a l 1 ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s [ " @ v a l 2 " ] . V a l u e   =   v a l 2 ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s [ " @ v a l 3 " ] . V a l u e   =   v a l 3 ;  
 	 	 	 	 s q l S a v e E b s V 5 . P a r a m e t e r s [ " @ v a l 4 " ] . V a l u e   =   v a l 4 ;  
  
 	 	 	 	 s q l S a v e E b s V 5 . E x e c u t e N o n Q u e r y ( ) ;  
 	 	 	 }  
 	 	 	 c a t c h   {  
 	 	 	 }  
 	 	 	 f i n a l l y   {  
 	 	 	 	 c o n . C l o s e ( ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 }  
 
