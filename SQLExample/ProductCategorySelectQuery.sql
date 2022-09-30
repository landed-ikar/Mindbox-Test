         SELECT product_name AS product,
		category_name AS category
           FROM products AS p
LEFT OUTER JOIN product_category AS pc
             ON p.product_id = pc.product_id
LEFT OUTER JOIN categories AS c
             ON c.category_id = pc.category_id
