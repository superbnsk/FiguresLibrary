select product.product_name, category.category_name 
from product
left join productcategory on product.product_id = productcategory.productid  
left join category on category.category_id = productcategory.categoryid
