namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Place AddContext10 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext10 ContextSwitchInterpreter
								if(AddContext10 != null)
								{
									System.Single OperandVar12 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop11 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar12 = prop11;
									AddContext10.Size = (System.Int32)( (OperandVar12));
								}
							}
							Named AddContext13 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext13 ContextSwitchInterpreter
								if(AddContext13 != null)
								{
									
									
									
									AddContext13.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar16 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar14 = default(System.String); //IsContext = False IsNew = False
									OperandVar14 = "human_name";
									System.String prop15 = External.RandomName( (OperandVar14)); //IsContext = False IsNew = False
									if(prop15 != null)
									{
										OperandVar16 = prop15;
									}
									AddContext13.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar16)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar18 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable17 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable17 != null)
						{
							OperandVar18 = StoredVariable17;
						}
						subContext5.Attach((Place)( (OperandVar18)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable19 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable19 != null)
			{
				System.Boolean ifResult20; //IsContext = False IsNew = False
				
				System.Boolean OperandVar27 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop21 = StoredVariable19.ShowedObject; //IsContext = False IsNew = False
				if(prop21 != null)
				{
					System.Boolean ifResult22; //IsContext = False IsNew = False
					System.Boolean OperandVar26 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar24 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable23 = ((Named)prop21.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable23 != null)
					{
						OperandVar24 = StoredVariable23;
					}
					System.Boolean prop25 = External.Has( (OperandVar24)); //IsContext = False IsNew = False
					OperandVar26 = prop25;
					if(ifResult22 =  (OperandVar26))
					{
						OperandVar27 = ifResult22;
					}
				}
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar29 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable28 = ((Blackboards.named_ui_marker)StoredVariable19.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable28 != null)
				{
					OperandVar29 = StoredVariable28;
				}
				System.Boolean prop30 = External.Has( (OperandVar29)); //IsContext = False IsNew = False
				OperandVar31 = prop30;
				if(ifResult20 = ( ( (OperandVar27))) && ( (!(OperandVar31))))
				{
					applicable = true;
					OperandVar32 = applicable;
				}
			}
			return (System.Boolean) (OperandVar32);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.named_ui_marker>();
			Entity EntVar33 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			
			
			{
				UiObject subContext34 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext34 ContextSwitchInterpreter
				if(subContext34 != null)
				{
					Named OperandVar37 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop35 = subContext34.ShowedObject; //IsContext = False IsNew = False
					if(prop35 != null)
					{
						Named StoredVariable36 = ((Named)prop35.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable36 != null)
						{
							OperandVar37 = StoredVariable36;
						}
					}
					Named showed_named =  (OperandVar37); //IsContext = False IsNew = False
					TextField ContextVar38 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar38 ContextSwitchInterpreter
						if(ContextVar38 != null)
						{
							System.String OperandVar40 = default(System.String); //IsContext = False IsNew = False
							System.String prop39 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop39 != null)
							{
								OperandVar40 = prop39;
							}
							ContextVar38.Show(( (OperandVar40)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda41 = () => 
									{
										System.String OperandVar43 = default(System.String); //IsContext = False IsNew = False
										System.String prop42 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop42 != null)
										{
											OperandVar43 = prop42;
										}
										ContextVar38.Show(( (OperandVar43)).ToString());
									};
									showed_named.OnUpdate(Lambda41);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext44 = ContextVar38.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext44 ContextPropertySwitchInterpreter
								if(subContext44 != null)
								{
									
									subContext44.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					if(EntVar33 != null) EntVar33.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar58 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable45 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable45 != null)
			{
				UiObject StoredVariable46 = ((UiObject)StoredVariable45.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable46 != null)
				{
					System.Boolean ifResult47; //IsContext = False IsNew = False
					
					System.Boolean OperandVar54 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop48 = StoredVariable46.ShowedObject; //IsContext = False IsNew = False
					if(prop48 != null)
					{
						System.Boolean ifResult49; //IsContext = False IsNew = False
						System.Boolean OperandVar53 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar51 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable50 = ((Place)prop48.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable50 != null)
						{
							OperandVar51 = StoredVariable50;
						}
						System.Boolean prop52 = External.Has( (OperandVar51)); //IsContext = False IsNew = False
						OperandVar53 = prop52;
						if(ifResult49 =  (OperandVar53))
						{
							OperandVar54 = ifResult49;
						}
					}
					
					System.Boolean OperandVar57 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar55 = default(System.String); //IsContext = False IsNew = False
					OperandVar55 = "place_ui_set";
					System.Boolean prop56 = StoredVariable45.HasMarker( (OperandVar55)); //IsContext = False IsNew = False
					OperandVar57 = prop56;
					if(ifResult47 = ( ( (OperandVar54))) && ( (!(OperandVar57))))
					{
						applicable = true;
						OperandVar58 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar58);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext59 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext59 ContextSwitchInterpreter
				if(subContext59 != null)
				{
					System.String OperandVar60 = default(System.String); //IsContext = False IsNew = False
					OperandVar60 = "place_ui_set";
					subContext59.SetMarker(( (OperandVar60)).ToString());
				}
			}
			
			{
				UiObject subContext61 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext61 ContextSwitchInterpreter
				if(subContext61 != null)
				{
					Place OperandVar64 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop62 = subContext61.ShowedObject; //IsContext = False IsNew = False
					if(prop62 != null)
					{
						Place StoredVariable63 = ((Place)prop62.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable63 != null)
						{
							OperandVar64 = StoredVariable63;
						}
					}
					Place pl =  (OperandVar64); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					Entity EntVar65 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar67 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop66 = pl.Size; //IsContext = False IsNew = False
							OperandVar67 = prop66;
							puidata.LastSize = (System.Int32)( (OperandVar67));
						}
					}
					TextField ContextVar68 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar68 ContextSwitchInterpreter
						if(ContextVar68 != null)
						{
							System.Int32 OperandVar70 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop69 = pl.Size; //IsContext = False IsNew = False
							OperandVar70 = prop69;
							ContextVar68.Show(( (OperandVar70)).ToString());
							System.Boolean OperandVar74 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar72 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable71 = ((Updated)ContextVar68.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable71 != null)
							{
								OperandVar72 = StoredVariable71;
							}
							System.Boolean prop73 = External.Has( (OperandVar72)); //IsContext = False IsNew = False
							OperandVar74 = prop73;
							if(!(OperandVar74))
							{
								root.AddComponent<Updated>();
								
							}
							
							{
								//ContextStatement TextField ContextVar68 ContextSwitchInterpreter
								if(ContextVar68 != null)
								{
									
									ContextVar68.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext75 = ContextVar68.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext75 ContextPropertySwitchInterpreter
								if(subContext75 != null)
								{
									
									subContext75.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext76 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext76 ContextSwitchInterpreter
								if(subContext76 != null)
								{
									BoolDelegate Lambda77 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar79 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop78 = pl.Size; //IsContext = False IsNew = False
															OperandVar79 = prop78;
														}
														
														System.Int32 OperandVar81 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop80 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar81 = prop80;
														}
														if(!(( ( (OperandVar79))) == ( ( (OperandVar81)))))
														{
															System.Int32 OperandVar83 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop82 = pl.Size; //IsContext = False IsNew = False
																OperandVar83 = prop82;
															}
															puidata.LastSize = (System.Int32)( (OperandVar83));
															System.Int32 OperandVar85 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop84 = pl.Size; //IsContext = False IsNew = False
																OperandVar85 = prop84;
															}
															ContextVar68.Show(( (OperandVar85)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext76.OnUpdate(Lambda77);
								}
							}
						}
					}
					if(EntVar65 != null) EntVar65.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar94 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable86 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable86 != null)
			{
				Place StoredVariable87 = ((Place)StoredVariable86.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable87 != null)
				{
					System.Boolean ifResult88; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar90 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop89 = StoredVariable87.Agents; //IsContext = False IsNew = False
					if(prop89 != null)
					{
						OperandVar90 = prop89;
					}
					
					
					
					System.Boolean OperandVar93 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar91 = default(System.String); //IsContext = False IsNew = False
					OperandVar91 = "agents_pool";
					System.Boolean prop92 = StoredVariable86.HasMarker( (OperandVar91)); //IsContext = False IsNew = False
					OperandVar93 = prop92;
					if(ifResult88 = ( (( ( (OperandVar90 != null ? OperandVar90.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar93))))
					{
						applicable = true;
						OperandVar94 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar94);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext95 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext95 ContextSwitchInterpreter
				if(subContext95 != null)
				{
					
					subContext95.Size = (System.Int32)( (5f));
					System.Single OperandVar97 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop96 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar97 = prop96;
					for (int i = 0; i <  (OperandVar97); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag98 = ag; //IsContext = True IsNew = False
							Entity AddContext99 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext100 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext101 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext101 ContextSwitchInterpreter
								if(AddContext101 != null)
								{
									System.Single OperandVar103 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop102 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar103 = prop102;
									AddContext101.Age = (System.Int32)( (OperandVar103));
								}
							}
							Named AddContext104 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext104 ContextSwitchInterpreter
								if(AddContext104 != null)
								{
									
									
									
									AddContext104.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar107 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar105 = default(System.String); //IsContext = False IsNew = False
									OperandVar105 = "human_name";
									System.String prop106 = External.RandomName( (OperandVar105)); //IsContext = False IsNew = False
									if(prop106 != null)
									{
										OperandVar107 = prop106;
									}
									AddContext104.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar107)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar109 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable108 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable108 != null)
						{
							OperandVar109 = StoredVariable108;
						}
						subContext95.Attach((Agent)( (OperandVar109)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar116 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable110 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable110 != null)
			{
				System.Boolean ifResult111; //IsContext = False IsNew = False
				System.Boolean OperandVar115 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar113 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable112 = ((Blackboards.event_marker)StoredVariable110.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable112 != null)
				{
					OperandVar113 = StoredVariable112;
				}
				System.Boolean prop114 = External.Has( (OperandVar113)); //IsContext = False IsNew = False
				OperandVar115 = prop114;
				if(ifResult111 = !(OperandVar115))
				{
					applicable = true;
					OperandVar116 = applicable;
				}
			}
			return (System.Boolean) (OperandVar116);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar117 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar117 != null) EntVar117.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar124 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable118 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable118 != null)
			{
				System.Boolean ifResult119; //IsContext = False IsNew = False
				System.Boolean OperandVar123 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar121 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable120 = ((Blackboards.personality)StoredVariable118.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable120 != null)
				{
					OperandVar121 = StoredVariable120;
				}
				System.Boolean prop122 = External.Has( (OperandVar121)); //IsContext = False IsNew = False
				OperandVar123 = prop122;
				if(ifResult119 = !(OperandVar123))
				{
					applicable = true;
					OperandVar124 = applicable;
				}
			}
			return (System.Boolean) (OperandVar124);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar125 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar125 != null) EntVar125.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar132 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable126 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable126 != null)
			{
				System.Boolean ifResult127; //IsContext = False IsNew = False
				System.Boolean OperandVar131 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar129 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable128 = ((Blackboards.aged_generation)StoredVariable126.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable128 != null)
				{
					OperandVar129 = StoredVariable128;
				}
				System.Boolean prop130 = External.Has( (OperandVar129)); //IsContext = False IsNew = False
				OperandVar131 = prop130;
				if(ifResult127 = !(OperandVar131))
				{
					applicable = true;
					OperandVar132 = applicable;
				}
			}
			return (System.Boolean) (OperandVar132);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar133 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar133 != null) EntVar133.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar143 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable134 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable134 != null)
			{
				Lore StoredVariable135 = ((Lore)StoredVariable134.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable135 != null)
				{
					Place StoredVariable136 = ((Place)StoredVariable135.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable136 != null)
					{
						System.Boolean ifResult137; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar139 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop138 = StoredVariable136.Agents; //IsContext = False IsNew = False
						if(prop138 != null)
						{
							OperandVar139 = prop138;
						}
						
						
						
						System.Boolean OperandVar142 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar140 = default(System.String); //IsContext = False IsNew = False
						OperandVar140 = "lore_pool";
						System.Boolean prop141 = StoredVariable134.HasMarker( (OperandVar140)); //IsContext = False IsNew = False
						OperandVar142 = prop141;
						if(ifResult137 = ( (( ( (OperandVar139 != null ? OperandVar139.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar142))))
						{
							applicable = true;
							OperandVar143 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar143);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext144 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext144 ContextSwitchInterpreter
				if(subContext144 != null)
				{
					
					subContext144.Size = (System.Int32)( (10f));
					System.Single OperandVar146 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop145 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar146 = prop145;
					for (int i = 0; i <  (OperandVar146); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag147 = old_ag; //IsContext = True IsNew = False
							Entity AddContext148 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext149 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext150 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext151 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext151 ContextSwitchInterpreter
								if(AddContext151 != null)
								{
									System.Single OperandVar153 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop152 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar153 = prop152;
									AddContext151.Age = (System.Int32)( (OperandVar153));
								}
							}
							Named AddContext154 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext154 ContextSwitchInterpreter
								if(AddContext154 != null)
								{
									
									
									
									AddContext154.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar157 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar155 = default(System.String); //IsContext = False IsNew = False
									OperandVar155 = "human_name";
									System.String prop156 = External.RandomName( (OperandVar155)); //IsContext = False IsNew = False
									if(prop156 != null)
									{
										OperandVar157 = prop156;
									}
									AddContext154.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar157)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar159 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable158 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable158 != null)
						{
							OperandVar159 = StoredVariable158;
						}
						subContext144.Attach((Agent)( (OperandVar159)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar169 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable160 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable160 != null)
			{
				Blackboards.historical_person StoredVariable161 = ((Blackboards.historical_person)StoredVariable160.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable161 != null)
				{
					Named StoredVariable162 = ((Named)StoredVariable161.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable162 != null)
					{
						Agent StoredVariable163 = ((Agent)StoredVariable162.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable163 != null)
						{
							System.Boolean ifResult164; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar166 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop165 = StoredVariable163.Act; //IsContext = False IsNew = False
							OperandVar166 = prop165;
							
							
							
							System.Boolean OperandVar168 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable160 != null)
							{
								System.Boolean prop167 = StoredVariable160.Dead; //IsContext = False IsNew = False
								OperandVar168 = prop167;
							}
							if(ifResult164 = ( (( ( (OperandVar166))) == ( ( (true))))) && ( (!(OperandVar168))))
							{
								applicable = true;
								OperandVar169 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar169);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext170 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext170 ContextSwitchInterpreter
				if(subContext170 != null)
				{
					
					System.String OperandVar173 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar171 = default(System.String); //IsContext = False IsNew = False
					OperandVar171 = "human_name";
					System.String prop172 = External.RandomName( (OperandVar171)); //IsContext = False IsNew = False
					if(prop172 != null)
					{
						OperandVar173 = prop172;
					}
					subContext170.Switch(( ("main_name")).ToString(),( (OperandVar173)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar179 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable174 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable174 != null)
			{
				Named StoredVariable175 = ((Named)StoredVariable174.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable175 != null)
				{
					System.Boolean ifResult176; //IsContext = False IsNew = False
					
					System.Boolean OperandVar178 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable174 != null)
					{
						System.Boolean prop177 = StoredVariable174.Act; //IsContext = False IsNew = False
						OperandVar178 = prop177;
					}
					
					
					if(ifResult176 = ( ( (OperandVar178))) == ( ( (true))))
					{
						applicable = true;
						OperandVar179 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar179);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar183 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable180 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable180 != null)
			{
				System.String OperandVar181 = default(System.String); //IsContext = False IsNew = False
				OperandVar181 = "main_name";
				System.String prop182 = StoredVariable180.Get( (OperandVar181)); //IsContext = False IsNew = False
				if(prop182 != null)
				{
					OperandVar183 = prop182;
				}
			}
			External.Log((System.Object)( (OperandVar183)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar191 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable184 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable184 != null)
			{
				Agent StoredVariable185 = ((Agent)StoredVariable184.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable185 != null)
				{
					System.Boolean ifResult186; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar188 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop187 = StoredVariable185.Act; //IsContext = False IsNew = False
					OperandVar188 = prop187;
					
					
					
					System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable184 != null)
					{
						System.Boolean prop189 = StoredVariable184.Dead; //IsContext = False IsNew = False
						OperandVar190 = prop189;
					}
					if(ifResult186 = ( (( ( (OperandVar188))) == ( ( (true))))) && ( (!(OperandVar190))))
					{
						applicable = true;
						OperandVar191 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar191);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar192 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar192 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar192)))));
			UnityEngine.GameObject OperandVar193 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar193 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar193)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar202 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable194 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable194 != null)
			{
				System.Boolean ifResult195; //IsContext = False IsNew = False
				
				System.Boolean OperandVar198 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar196 = default(System.String); //IsContext = False IsNew = False
				OperandVar196 = "init_node";
				System.Boolean prop197 = StoredVariable194.HasMarker( (OperandVar196)); //IsContext = False IsNew = False
				OperandVar198 = prop197;
				
				System.Boolean OperandVar201 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar199 = default(System.String); //IsContext = False IsNew = False
				OperandVar199 = "story_set";
				System.Boolean prop200 = StoredVariable194.HasMarker( (OperandVar199)); //IsContext = False IsNew = False
				OperandVar201 = prop200;
				if(ifResult195 = ( ( (OperandVar198))) && ( (!(OperandVar201))))
				{
					applicable = true;
					OperandVar202 = applicable;
				}
			}
			return (System.Boolean) (OperandVar202);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext203 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext203 ContextSwitchInterpreter
				if(subContext203 != null)
				{
					System.String OperandVar204 = default(System.String); //IsContext = False IsNew = False
					OperandVar204 = "story_set";
					subContext203.SetMarker(( (OperandVar204)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node205 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext206 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext207 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Entity AddContext208 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext209 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext210 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext210 ContextPropertySwitchInterpreter
				if(subContext210 != null)
				{
					
					{
						TaleNode subContext211 = (TaleNode)subContext210.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext211 ContextSwitchInterpreter
						if(subContext211 != null)
						{
							
							subContext211.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar221 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable212 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable212 != null)
			{
				Blackboards.story_node StoredVariable213 = ((Blackboards.story_node)StoredVariable212.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable213 != null)
				{
					TaleNode StoredVariable214 = ((TaleNode)StoredVariable213.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable214 != null)
					{
						System.Boolean ifResult215; //IsContext = False IsNew = False
						
						System.Boolean OperandVar218 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar216 = default(System.String); //IsContext = False IsNew = False
						OperandVar216 = "decomposed";
						System.Boolean prop217 = StoredVariable212.HasMarker( (OperandVar216)); //IsContext = False IsNew = False
						OperandVar218 = prop217;
						
						System.Boolean OperandVar220 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop219 = StoredVariable214.IsActive; //IsContext = False IsNew = False
						OperandVar220 = prop219;
						if(ifResult215 = ( (!(OperandVar218))) && ( ( (OperandVar220))))
						{
							applicable = true;
							OperandVar221 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar221);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext222 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext222 ContextSwitchInterpreter
				if(subContext222 != null)
				{
					System.String OperandVar223 = default(System.String); //IsContext = False IsNew = False
					OperandVar223 = "decomposed";
					subContext222.SetMarker(( (OperandVar223)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node224 = c_node; //IsContext = True IsNew = False
				Markers AddContext225 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext226 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext227 = (Entity)c_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext228 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node229 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext230 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext231 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext232 = (Entity)c_r_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext233 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext233 ContextSwitchInterpreter
					if(AddContext233 != null)
					{
						UnityEngine.GameObject OperandVar234 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar234 = c_node;
						AddContext233.Conflict = (UnityEngine.GameObject)( (OperandVar234));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node235 = r_node; //IsContext = True IsNew = False
				Markers AddContext236 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext237 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext238 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext238 ContextSwitchInterpreter
					if(AddContext238 != null)
					{
						UnityEngine.GameObject OperandVar239 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar239 = c_r_node;
						AddContext238.Resolution = (UnityEngine.GameObject)( (OperandVar239));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node240 = s_node; //IsContext = True IsNew = False
				Markers AddContext241 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext242 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				TaleNode AddContext243 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext244 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext244 ContextSwitchInterpreter
					if(AddContext244 != null)
					{
						UnityEngine.GameObject OperandVar245 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar245 = c_r_node;
						AddContext244.Cause = (UnityEngine.GameObject)( (OperandVar245));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node246 = cris_node; //IsContext = True IsNew = False
				Entity AddContext247 = (Entity)cris_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext248 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext249 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext250 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext250 ContextSwitchInterpreter
					if(AddContext250 != null)
					{
						UnityEngine.GameObject OperandVar251 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar251 = s_node;
						AddContext250.Solution = (UnityEngine.GameObject)( (OperandVar251));
						UnityEngine.GameObject OperandVar252 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar252 = r_node;
						AddContext250.Cause = (UnityEngine.GameObject)( (OperandVar252));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext253 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext253 ContextPropertySwitchInterpreter
				if(subContext253 != null)
				{
					
					{
						TaleNode subContext254 = (TaleNode)subContext253.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext254 ContextSwitchInterpreter
						if(subContext254 != null)
						{
							
							subContext254.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext255 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext255 ContextPropertySwitchInterpreter
				if(subContext255 != null)
				{
					
					{
						TaleNode subContext256 = (TaleNode)subContext255.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext256 ContextSwitchInterpreter
						if(subContext256 != null)
						{
							
							subContext256.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext257 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext257 ContextPropertySwitchInterpreter
				if(subContext257 != null)
				{
					
					{
						TaleNode subContext258 = (TaleNode)subContext257.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext258 ContextSwitchInterpreter
						if(subContext258 != null)
						{
							
							subContext258.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext259 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext259 ContextPropertySwitchInterpreter
				if(subContext259 != null)
				{
					
					{
						TaleNode subContext260 = (TaleNode)subContext259.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext260 ContextSwitchInterpreter
						if(subContext260 != null)
						{
							
							subContext260.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext261 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext261 ContextPropertySwitchInterpreter
				if(subContext261 != null)
				{
					
					{
						TaleNode subContext262 = (TaleNode)subContext261.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext262 ContextSwitchInterpreter
						if(subContext262 != null)
						{
							
							subContext262.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar272 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable263 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable263 != null)
			{
				Blackboards.conflict_node StoredVariable264 = ((Blackboards.conflict_node)StoredVariable263.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable264 != null)
				{
					TaleNode StoredVariable265 = ((TaleNode)StoredVariable264.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable265 != null)
					{
						System.Boolean ifResult266; //IsContext = False IsNew = False
						
						System.Boolean OperandVar269 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar267 = default(System.String); //IsContext = False IsNew = False
						OperandVar267 = "decomposed";
						System.Boolean prop268 = StoredVariable263.HasMarker( (OperandVar267)); //IsContext = False IsNew = False
						OperandVar269 = prop268;
						
						System.Boolean OperandVar271 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop270 = StoredVariable265.IsActive; //IsContext = False IsNew = False
						OperandVar271 = prop270;
						if(ifResult266 = ( (!(OperandVar269))) && ( ( (OperandVar271))))
						{
							applicable = true;
							OperandVar272 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar272);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node273 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext274 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Entity AddContext275 = (Entity)f_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext276 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext276 ContextSwitchInterpreter
						if(AddContext276 != null)
						{
							UnityEngine.GameObject OperandVar277 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar277 = root;
							AddContext276.Conflict = (UnityEngine.GameObject)( (OperandVar277));
						}
					}
					Markers AddContext278 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext279 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext279 ContextPropertySwitchInterpreter
					if(subContext279 != null)
					{
						
						{
							TaleNode subContext280 = (TaleNode)subContext279.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext280 ContextSwitchInterpreter
							if(subContext280 != null)
							{
								
								subContext280.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext281 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext281 ContextSwitchInterpreter
				if(subContext281 != null)
				{
					System.String OperandVar282 = default(System.String); //IsContext = False IsNew = False
					OperandVar282 = "decomposed";
					subContext281.SetMarker(( (OperandVar282)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar289 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable283 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable283 != null)
			{
				TaleNode StoredVariable284 = ((TaleNode)StoredVariable283.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable284 != null)
				{
					System.Boolean ifResult285; //IsContext = False IsNew = False
					System.Boolean OperandVar288 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar286 = default(System.String); //IsContext = False IsNew = False
					OperandVar286 = "tale_enlisted";
					System.Boolean prop287 = StoredVariable283.HasMarker( (OperandVar286)); //IsContext = False IsNew = False
					OperandVar288 = prop287;
					if(ifResult285 = !(OperandVar288))
					{
						applicable = true;
						OperandVar289 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar289);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui290 = ui; //IsContext = True IsNew = False
				UiObject AddContext291 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext291 ContextSwitchInterpreter
					if(AddContext291 != null)
					{
						UnityEngine.GameObject OperandVar292 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar292 = root;
						AddContext291.ShowedObject = (UnityEngine.GameObject)( (OperandVar292));
						
						{
							UnityEngine.UI.LayoutElement subContext293 = AddContext291.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext293 ContextPropertySwitchInterpreter
							if(subContext293 != null)
							{
								
								subContext293.minHeight = (System.Single)( (30f));
							}
						}
					}
				}
				TextField AddContext294 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext294 ContextSwitchInterpreter
					if(AddContext294 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext295 = AddContext294.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext295 ContextPropertySwitchInterpreter
							if(subContext295 != null)
							{
								
								subContext295.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar298 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar296 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar296 = root;
						System.String prop297 = External.Stringify( (OperandVar296)); //IsContext = False IsNew = False
						if(prop297 != null)
						{
							OperandVar298 = prop297;
						}
						AddContext294.Show(( (OperandVar298)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar299 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar299 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar299)));
			
			{
				Markers subContext300 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext300 ContextSwitchInterpreter
				if(subContext300 != null)
				{
					System.String OperandVar301 = default(System.String); //IsContext = False IsNew = False
					OperandVar301 = "tale_enlisted";
					subContext300.SetMarker(( (OperandVar301)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar308 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable302 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable302 != null)
			{
				Markers StoredVariable303 = ((Markers)StoredVariable302.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable303 != null)
				{
					System.Boolean ifResult304; //IsContext = False IsNew = False
					System.Boolean OperandVar307 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar305 = default(System.String); //IsContext = False IsNew = False
					OperandVar305 = "faction_is_a_state";
					System.Boolean prop306 = StoredVariable303.HasMarker( (OperandVar305)); //IsContext = False IsNew = False
					OperandVar307 = prop306;
					if(ifResult304 = !(OperandVar307))
					{
						applicable = true;
						OperandVar308 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar308);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar309 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar309 != null) EntVar309.ComponentAdded();
			
			{
				Markers subContext310 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext310 ContextSwitchInterpreter
				if(subContext310 != null)
				{
					System.String OperandVar311 = default(System.String); //IsContext = False IsNew = False
					OperandVar311 = "faction_is_a_state";
					subContext310.SetMarker(( (OperandVar311)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar318 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable312 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable312 != null)
			{
				System.Boolean ifResult313; //IsContext = False IsNew = False
				System.Boolean OperandVar317 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar315 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable314 = ((Named)StoredVariable312.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable314 != null)
				{
					OperandVar315 = StoredVariable314;
				}
				System.Boolean prop316 = External.Has( (OperandVar315)); //IsContext = False IsNew = False
				OperandVar317 = prop316;
				if(ifResult313 = !(OperandVar317))
				{
					applicable = true;
					OperandVar318 = applicable;
				}
			}
			return (System.Boolean) (OperandVar318);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar319 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar319 ContextSwitchInterpreter
				if(ContextVar319 != null)
				{
					
					
					System.String OperandVar322 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar320 = default(System.String); //IsContext = False IsNew = False
					OperandVar320 = "country_name";
					System.String prop321 = External.RandomName( (OperandVar320)); //IsContext = False IsNew = False
					if(prop321 != null)
					{
						OperandVar322 = prop321;
					}
					ContextVar319.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar322)).ToString());
				}
			}
			Entity EntVar323 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar323 != null) EntVar323.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar333 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable324 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable324 != null)
			{
				TaleNode StoredVariable325 = ((TaleNode)StoredVariable324.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable325 != null)
				{
					System.Boolean ifResult326; //IsContext = False IsNew = False
					
					System.Boolean OperandVar330 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar328 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable324 != null)
					{
						UnityEngine.GameObject prop327 = StoredVariable324.Head; //IsContext = False IsNew = False
						if(prop327 != null)
						{
							OperandVar328 = prop327;
						}
					}
					System.Boolean prop329 = External.Has( (OperandVar328)); //IsContext = False IsNew = False
					OperandVar330 = prop329;
					
					System.Boolean OperandVar332 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop331 = StoredVariable325.IsActive; //IsContext = False IsNew = False
					OperandVar332 = prop331;
					if(ifResult326 = ( (!(OperandVar330))) && ( ( (OperandVar332))))
					{
						applicable = true;
						OperandVar333 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar333);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.state_node subContext334 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext334 ContextSwitchInterpreter
				if(subContext334 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state335 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext336 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext337 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext338 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext339 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext339 ContextSwitchInterpreter
							if(AddContext339 != null)
							{
								UnityEngine.GameObject OperandVar340 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar340 = root;
								AddContext339.State = (UnityEngine.GameObject)( (OperandVar340));
							}
						}
						Entity AddContext341 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Entity AddContext341 ContextSwitchInterpreter
							if(AddContext341 != null)
							{
								GODelegate Lambda342 = (UnityEngine.GameObject entity) => 
								{
									
									UnityEngine.GameObject OperandVar343 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar343 = head_of_state;
									subContext334.PastHeads.Add( (OperandVar343));
									
									{
										UnityEngine.GameObject subContext344 = root; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext344 ContextPropertySwitchInterpreter
										if(subContext344 != null)
										{
											
											{
												//ContextStatement Blackboards.state_node subContext334 ContextSwitchInterpreter
												if(subContext334 != null)
												{
													UnityEngine.GameObject OperandVar346 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
													UnityEngine.GameObject prop345 = External.NoOne(); //IsContext = False IsNew = False
													if(prop345 != null)
													{
														OperandVar346 = prop345;
													}
													subContext334.Head = (UnityEngine.GameObject)( (OperandVar346));
												}
											}
										}
									}
								};
								AddContext341.OnDestruction(Lambda342);
							}
						}
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext347 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext347 ContextPropertySwitchInterpreter
						if(subContext347 != null)
						{
							
							{
								TaleNode subContext348 = (TaleNode)subContext347.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext348 ContextSwitchInterpreter
								if(subContext348 != null)
								{
									
									subContext348.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar349 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar349 = head_of_state;
					subContext334.Head = (UnityEngine.GameObject)( (OperandVar349));
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar356 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable350 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable350 != null)
			{
				System.Boolean ifResult351; //IsContext = False IsNew = False
				System.Boolean OperandVar355 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar353 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable352 = ((Named)StoredVariable350.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable352 != null)
				{
					OperandVar353 = StoredVariable352;
				}
				System.Boolean prop354 = External.Has( (OperandVar353)); //IsContext = False IsNew = False
				OperandVar355 = prop354;
				if(ifResult351 = !(OperandVar355))
				{
					applicable = true;
					OperandVar356 = applicable;
				}
			}
			return (System.Boolean) (OperandVar356);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar357 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar357 ContextSwitchInterpreter
				if(ContextVar357 != null)
				{
					System.String OperandVar358 = default(System.String); //IsContext = False IsNew = False
					OperandVar358 = "main_name";
					
					System.String OperandVar361 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar359 = default(System.String); //IsContext = False IsNew = False
					OperandVar359 = "human_name";
					System.String prop360 = External.RandomName( (OperandVar359)); //IsContext = False IsNew = False
					if(prop360 != null)
					{
						OperandVar361 = prop360;
					}
					ContextVar357.Set(( (OperandVar358)).ToString(),(System.Single)( (0f)),( (OperandVar361)).ToString());
				}
			}
			Entity EntVar362 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar362 != null) EntVar362.ComponentAdded();
		}
        }
    }
}
