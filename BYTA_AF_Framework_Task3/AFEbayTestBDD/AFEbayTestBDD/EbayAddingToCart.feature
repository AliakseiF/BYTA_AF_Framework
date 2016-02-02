Feature: EbayAddingToCart

@search
Scenario Outline: Search
	Given I have entered <query> into search field
	When I press search button
	Then The result should contain <query> in search results
Examples: 
| query     |
| ipad		|
| iphone 5s |

@addFromResults
Scenario Outline: AddToCartFromResults
	Given I have entered <query> into search field
	When I press search button
	And I open item details page of the first result item
	And I enter <quantity> in quantity and press add to cart button
	Then Shopping cart page should be opened 
	And Specified item should be in shopping cart
Examples: 
| query | quantity |
| 100   | 2        |

@addFromWishList
Scenario: AddToCartFromWishList
	Given I as registered user have opened wish list page
	When I press add to cart button
	Then Shopping cart page should be opened 
	And Specified item should be in shopping cart

