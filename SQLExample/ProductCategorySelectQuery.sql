         select product_name as product,
				category_name as category
           from products as p
left outer join product_category as pc
             on p.product_id = pc.product_id
left outer join categories as c
             on c.category_id = pc.category_id