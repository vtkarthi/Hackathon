//    Demo json  loaded from dropbox 
//    Data = http://codepen.io/nakome/pen/DnEvr.js
//[   
//   {
//      "photo":"image url ",
//      "name":"Jhon",
//      "last":"Smith",
//      "email":"jhony@site.com",
//      "phone":"1-555-222-333",
//      "web":"http://jhonSmith.com"
//   },
//   { 
//      "photo":"image url",
//      "name":"Carla",
//      "last":"Doe",
//      "email":"carladoe@site.com",
//      "phone":"1-333-111-555",
//      "web":"http://carladoe.com"
//   }
// ]


(function(){
  
  'use-strict';
  
  var elem,
      // data-fn
      dataFn = $('[data-fn="contacts"]'),
      // data-url
      thisUrl = dataFn.data('url');
  //thisUrl = 'http://localhost:50984/api/mc/1';
  
  if (typeof $.table_of_contacts == 'undefined')
    
    $.table_of_contacts = {};
  
  $.table_of_contacts.get = {
    
    init: function() {
      if(dataFn){
        this.getJson(thisUrl);
      }else{
        dataFn.html('No data found.');
      }
    },
    
    /* = Get data
    ------------------------*/
    getJson: function(url){
      
      var self = this;
      
      // loading data before
      dataFn.html('<span class="loading_table">'+
                  'Loading Please Wait ....'+
                  '</span>');
      
      // No ajax cache
      $.ajaxSetup({ cache: false });
      
      // Get json
      $.getJSON(thisUrl,function(data){
        
        // load template
        var out_html = self.tpl(); 
        
        $.each(data,function(i,obj){  
          // load inner template
          out_html += self.tpl_inner(obj);
          
        });
        // close tag
        out_html += '</tbody>';
        // render templates
        dataFn.html(out_html);
        var timeoutID = window.setTimeout($.table_of_contacts.getJson(), 3000);
        // error 
      }).error(function(j,t,e){ 
        // render error.
        dataFn.html('<span class="error_table">'+
                    'Error = '+e+
                    '</span>');
        
      });
    },
    
    // head table template
    tpl: function(){
      var html = '<thead>'+
          '<tr>'+
          '<th>Photo</th>'+
          '<th>AgentId</th>' +
         // '<th>Last Name</th>'+    
          '<th>StatusTimestamp</th>' +
          '<th>Duration</th>'+
          //'<th>Web</th>'+
          '</tr>'+
          '</thead>'+
          '<tbody >';
      return html;
    },
    // inner template
    tpl_inner: function(obj){
      
      var  html= '<tr>'+
          '<td class="user-photo">'+
          '<img class="user-tumb" src="'+obj.photo+'"/>'+
          '</td>'+
          '<td>' + obj.AgentId + '</td>' +
          //'<td>'+obj.last+'</td>'+
          '<td>' + obj.StatusTimestamp + '</td>' +
          '<td>' + obj.Duration + '</td>' +
         // '<td>'+
         // '<a href="'+obj.web+'" title="'+
         // obj.name + ' ' + obj.last+'">'+
         // obj.web +
         // '</td>'+
          '</tr>'; 
      return html;
    }
    
  };
 
  $.table_of_contacts.report = {

      init: function () {
          if (dataFn) {
              this.getJson(thisUrl);
          } else {
              dataFn.html('No data found.');
          }
      },

      /* = Get data
      ------------------------*/
      getJson: function (url) {

          var self = this;

          // loading data before
          dataFn.html('<span class="loading_table">' +
                      'Loading Please Wait ....' +
                      '</span>');

          // No ajax cache
          $.ajaxSetup({ cache: false });

          // Get json
          $.getJSON(thisUrl, function (data) {

              // load template
              var out_html = self.tpl();

              $.each(data, function (i, obj) {
                  // load inner template
                  out_html += self.tpl_inner(obj);

              });
              // close tag
              out_html += '</tbody>';
              // render templates
              dataFn.html(out_html);
              
              // error 
          }).error(function (j, t, e) {
              // render error.
              dataFn.html('<span class="error_table">' +
                          'Error = ' + e +
                          '</span>');

          });
      },

      // head table template
      tpl: function () {
          var html = '<thead>' +
              '<tr>' +
              '<th>AgentRealtimeInfoId</th>' +
              '<th>AgentId</th>' +
              '<th>AgentStatus Name</th>'+    
              '<th>StatusTimestamp</th>' +              
              '</tr>' +
              '</thead>' +
              '<tbody >';
          return html;
      },
      // inner template
      tpl_inner: function (obj) {

          var html = '<tr>' +
              
              '<td>' + obj.AgentRealtimeInfoId + '</td>' +
             '<td>' + obj.AgentId + '</td>' +
              '<td>' + obj.AgentStatus + '</td>' +
              '<td>' + obj.StatusTimestamp + '</td>' +
             // '<td>'+
             // '<a href="'+obj.web+'" title="'+
             // obj.name + ' ' + obj.last+'">'+
             // obj.web +
             // '</td>'+
              '</tr>';
          return html;
      }

  };
  // on ready render data
  $(document).ready(function() {
      $.table_of_contacts.get.init();
      $.table_of_contacts.report.init();
  });
})().call(this);